using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    class UserListViewModel: BaseViewModel
    {

        private int _arabNumber;
        private string _romanNumber;

        private DateTime _time;

        private RelayCommand<object> _signOutCommand;
        private RelayCommand<object> _goBackCommand;

        public ObservableCollection<Request> _requests;

        internal UserListViewModel()
        {
            _requests = StationManager.UserHistoryList;
            MessageBox.Show("worked"+ _requests);
        }
        public int ArabNumber
        {
            get { return _arabNumber; }
            set { _arabNumber = value; }
        }
        public string RomanNumber
        {
            get { return _romanNumber; }
            set { _romanNumber = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public ObservableCollection<Request> Requests
        {
            get { return _requests; }
            set
            {
                _requests = value;
                OnPropertyChanged();
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
