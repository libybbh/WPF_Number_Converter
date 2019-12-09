using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private string _arabNumber;
        private DateTime _date;
        private ICommand _convertCoommand;
        private RelayCommand<object> _historyCommand;
        private RelayCommand<object> _signOutCommand;

        public string ArabNumber
        {
            get { return _arabNumber; }
            set
            {
                _arabNumber = value;
                OnPropertyChanged();
            }
        }

        public int ArabNumberInt
        {
            get { return int.Parse(ArabNumber); }

        }


        private void _UpdateField<T>(ref T field, T newValue, string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                OnPropertyChanged(propertyName);
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set{
                _date = DateTime.Now;
                OnPropertyChanged();
            }
        }

        public ICommand ConvertCommand
        {
            get
            {
                return _convertCoommand ?? (_convertCoommand =
                           new RelayCommand<object>(Convert));
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




        private async void Convert(object obj)
        {
            string userLogin = StationManager.CurrentUser.Login;
            User userCur = StationManager.DataStorage.GetUserByLogin(userLogin);

            string romanFinal = StationManager.DataStorage.CalculateAndSave(ArabNumberInt, userCur);

            MessageBox.Show(romanFinal);

        }

        private async void GoToHistory(object obj)
        {

            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
            {
                string userLogin = StationManager.CurrentUser.Login;
                StationManager.UserHistoryList = StationManager.DataStorage.GetHistoryByLogin(userLogin);


            });
            LoaderManager.Instance.HideLoader();
            NavigationManager.Instance.Navigate(ViewType.UserList);

        }

        public RelayCommand<object> ToHistoryCommand
        {
            get
            {
                return _historyCommand ?? (_historyCommand = new RelayCommand<object>(GoToHistory));
            }

        }


    /*public string CurrentUser
        {
            get
            {
                return $"Current User {StationManager.CurrentUser}";
            }
        }*/

    }
}
