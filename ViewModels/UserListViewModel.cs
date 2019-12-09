using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using System.Collections.ObjectModel;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    class UserListViewModel : BaseViewModel
    {

        private RelayCommand<object> _signOutCommand;
        private RelayCommand<object> _goBackCommand;

        public ObservableCollection<Request> _requests;


        public string HistoryText { get; set; }

        public UserListViewModel()
        {
            _requests = new ObservableCollection<Request>(StationManager.UserHistoryList);

            foreach (var r in _requests)
            {
                HistoryText += r.ToString();
            }


        }
        public RelayCommand<object> SignOutCommand
        {
            get
            {
                return _signOutCommand ?? (_signOutCommand = new RelayCommand<object>(
                           o =>
                           {
                               StationManager.CurrentUser = null;
                               StationManager.UserHistoryList = null;
                               NavigationManager.Instance.Navigate(ViewType.SignIn);
                           }));
            }
        }


        public RelayCommand<object> GoBackCommand
        {
            get
            {
                return _goBackCommand ?? (_goBackCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.Main);
                           }));
            }
        }

    }
}
