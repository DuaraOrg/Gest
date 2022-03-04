
namespace Gest.Core.Entities
{
    public class Period
    {
        public const string Tous = "Tous";

        public const string Today = "Aujourd'hui";

        public const string Yesterday = "Hier";

        public const string ThisWeek = "Cette semaine";

        public const string ThisMonth = "Ce moi";

        public const string Date = "Date";

        public const string IntervalDate = "Interval de date";

        public static IEnumerable<string> AllWithTous()
       => new List<string>() { Tous, Today, Yesterday, ThisWeek, ThisMonth, Date,IntervalDate };

        public static IEnumerable<string> All()
            => new List<string>() { Today, Yesterday, ThisWeek, ThisMonth, Date, IntervalDate };
    }
}
