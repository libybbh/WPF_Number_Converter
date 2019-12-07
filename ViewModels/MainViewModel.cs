using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private string _arabNumber;
        private string _romanNumber;
        private DateTime _date;
        private ICommand _convertCoommand;
        private string _label;

       
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

        public string Shirt
        {
            /* get { return $"Current User {StationManager.CurrentUser}"; }
             set {
                 _label = value;
                 OnPropertyChanged();
             }
            // _UpdateField(ref _label, value);*/
            get
            {
                return $"Current User {StationManager.CurrentUser}";
            }
            set
            {
               _label = $"User {StationManager.CurrentUser}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

            string romanFinal = StationManager.DataStorage.CalculateAndSave(ArabNumberInt, userCur);

            MessageBox.Show(romanFinal);
            
            _label = romanFinal;
            ObservableCollection<Request> requests = new ObservableCollection<Request>();


            //MessageBox.Show("" + StationManager.DataStorage.GetHistoryByLogin(userLogin));

            //NavigationManager.Instance.Navigate(ViewType.Main);


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
