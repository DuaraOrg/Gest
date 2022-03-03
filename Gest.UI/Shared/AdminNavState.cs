namespace Gest.UI.Shared
{
    public class AdminNavState
    {
        private string _currentUrl = string.Empty;

        public AdminNavState()
        {
            CurrentUrl = "/";
        }
        public bool IsSideNavOpen { get; private set; }

        public string CurrentUrl
        {
            get => _currentUrl;
            set
            {
                _currentUrl = value;
                NotifyStateChanged();
            }
        }
        
        public event Action<bool>? OnChange;
        
        public void SetState(bool newState)
        {
            if(IsSideNavOpen != newState)
            {
                IsSideNavOpen = newState;
                NotifyStateChanged();
            }
        }
        
        private void NotifyStateChanged()
        {
            OnChange?.Invoke(IsSideNavOpen);
        }
    }
}