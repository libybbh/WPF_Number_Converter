using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using System;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Input;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private string _arabNumber;
        private string _romanNumber;
        private DateTime _date;
        public Label RomanNumber = new Label();

        private ICommand _convertCoommand;

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


        public string RomeNum
        {
            get { return _romanNumber; }
            set
            {
                _romanNumber = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = DateTime.Now;
                OnPropertyChanged();
            }
        }

        public ICommand ConvertCoommand
        {
            get
            {
                return _convertCoommand ?? (_convertCoommand =
                           new RelayCommand<object>(Convert));
            }
        }

        private async void Convert(object obj)
        {
            string userLogin = StationManager.CurrentUser.Login;
            User userCur = StationManager.DataStorage.GetUserByLogin(userLogin);

            StationManager.DataStorage.CalculateAndSave(ArabNumberInt, userCur);

            MessageBox.Show("Wrote");

        }

        public string CurrentUser
        {
            get
            {
                return $"Current User {StationManager.CurrentUser}";
            }
        }

    }
}
