using Gest.Core.Data;
using Gest.Core.Entities;
using Gest.Core.Extensions;

namespace Gest.UI._Features_.Sales
{
    public static class Services
    {
        public static async Task<int> SaveSale(this GestDbContext dbContext, List<SaleItem> items, Client client, Company company, User user, Branch branch, DateTime datOfOperation, decimal total, decimal totalPaid, decimal rest,string paymentMethod, bool isNotDelivered)
        {
            dbContext.ChangeTracker.Clear();
            if (!isNotDelivered)
            {
                foreach (var item in items)
                {
                    var stockMovement = new StockMouvement()
                    {
                        ArticleId = item.Article!.Id,
                        Date = DateTime.UtcNow,
                        PrevStock = item.Article.Stock.Qty,
                        NewStock = item.Article.Stock.Qty - item.QtyInUnitOfMeasure,
                        Qty = item.QtyInUnitOfMeasure,
                        State = StockState.Out,
                        PrevSellingPrice = item.Article.Price.SellingPricePerUnitOfMeasure,
                        NewSellingPrice = item.Article.Price.SellingPricePerUnitOfMeasure,
                        NewBuyingPrice = item.Article.Price.BuyingPricePerUnitOfMeasure,
                        PrevBuyingPrice = item.Article.Price.BuyingPricePerUnitOfMeasure
                    };
                    var article = dbContext.Articles.First(x => x.Id == item.ArticleId);
                    article.Stock.Qty = stockMovement.NewStock;
                    await dbContext.StockMouvements.AddAsync(stockMovement);
                    dbContext.Update(article);
                }
                items.ForEach(x =>
                {
                    x.QtyDelivered = x.QtyInUnitOfMeasure;
                    x.Article = null;
                });
            }
            else
            {
                items.ForEach(x =>
                {
                    x.Article = null;
                });
            }
            var lastSaleId = dbContext.Sales
           .Where(x => x.CompanyId == company.Id)
           .OrderByDescending(x => x.SaleId)
           .FirstOrDefault()?.SaleId ?? 0;
            var sale = new Sale()
            {
                SaleId = lastSaleId + 1,
                Items = items,
                AmountPaid = totalPaid,
                ClientId = client.Id,
                CompanyId = company.Id,
                BranchId = branch.Id,
                CreatedAt = datOfOperation,
                UpdatedAt = DateTime.UtcNow,
                DeliverStatus = isNotDelivered ? DeliveryStatus.Pending : DeliveryStatus.Delivered,
                PayStatus = totalPaid >= total ? PaymentStatus.Paid : totalPaid > 0 ? PaymentStatus.InPayement : PaymentStatus.InPayement,
                SellerId = user.Id,
                TotalAmount = total
            };
            var addedSale = await dbContext.AddAsync(sale);
            var wallet = dbContext.Wallets.SingleOrDefault(x => x.Id == company.WalletId);
            if (wallet is null)
            {
                var newWallet = new Wallet()
                {
                    CreatedAt = DateTime.UtcNow
                };
                var addWallet = await dbContext.AddAsync(newWallet);
                wallet = addWallet.Entity;
                company.WalletId = wallet.Id;
                var mycompany = dbContext.Companies.First(x => x.Id == company.Id);
                mycompany.WalletId = wallet.Id;
                dbContext.Update(mycompany);
                await dbContext.SaveChangesAsync();
            }
            if (totalPaid > 0)
            {
                var lastPaymentId = dbContext.GetLastPaymentId(company.Id);
                var payment = new Payment()
                {
                    PayementId = lastPaymentId + 1,
                    ClientId = client.Id,
                    AccountType = paymentMethod,
                    Amount = totalPaid,
                    CreatedAt = DateTime.UtcNow,
                    SaleId = addedSale.Entity.Id,
                    CompanyId = company.Id,
                    TransType = TransactionType.SalePayment,
                    UserId = user.Id,
                    UpdatedAt = DateTime.UtcNow,
                    Category = "Vente"
                };
                await dbContext.AddAsync(payment);
                var walletMouvement = new WalletMovement()
                {
                    ToAccountType = TypeOfAccount.Cash,
                    Amount = totalPaid,
                    ToWalletId = wallet.Id,
                    Date = DateTime.UtcNow,
                    TransType = TransactionType.SalePayment
                };
                await dbContext.AddAsync(walletMouvement);
                wallet.Cash.Amount += totalPaid;
                wallet.UpdatedAt = DateTime.UtcNow;
                dbContext.Update(wallet);
            }
            if (rest > 0)
            {
                var clientWallet = dbContext.Wallets.SingleOrDefault(x => x.Id == client.WalletId);
                if (clientWallet is null)
                {
                    var newWallet = new Wallet()
                    {
                        CreatedAt = DateTime.UtcNow
                    };
                    var addWallet = await dbContext.AddAsync(newWallet);
                    clientWallet = addWallet.Entity;
                    var myclient = dbContext.Clients.First(x => x.Id == client.Id);
                    myclient.WalletId = wallet.Id;
                    dbContext.Update(myclient);
                    await dbContext.SaveChangesAsync();
                }
                var walletMouvement = new WalletMovement()
                {
                    FromWalletId = wallet.Id,
                    ToAccountType = TypeOfAccount.Credit,
                    Amount = rest,
                    ToWalletId = clientWallet.Id,
                    Date = DateTime.UtcNow,
                    TransType = TransactionType.SalePayment
                };
                await dbContext.AddAsync(walletMouvement);
                clientWallet.Credit.Amount += rest;
                clientWallet.UpdatedAt = DateTime.UtcNow;
                dbContext.Update(wallet);
            }

            var result = await dbContext.SaveChangesAsync();
            return result;
        }
    }
}
