using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private int _arabNum;
        private string _romeNum;
        private string _date;
        private string _RomanNum;
        public Label RomanNum = new Label();

        private ICommand _convertCoommand;
        private ICommand _resCoommand;

        public int ArabNum
        {
            get { return _arabNum; }
            set
            {
                _arabNum = value;
                OnPropertyChanged();
            }
        }

        

        public string RomeNum
        {
            get { return _romeNum; }
            set
            {
                _romeNum = value;
                OnPropertyChanged();
            }
        }

        public string Date
        {
            get { return _date; }
            set
            {
                _date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
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


        public ICommand ResCoommand
        {
            get
            {
                return _resCoommand ?? (_resCoommand =
                           new RelayCommand<object>(Convert));
            }
        }


        private async void Result(object obj)
        {
            //var user = StationManager.CurrentUser;
            string rNumber = StationManager.DataStorage.CalculateNumber(_arabNum);

           // var textContainer = TextContainerProp.GetValue(tb);

            var rqs = new Request(_arabNum, rNumber, _date);
            StationManager.DataStorage.CalculateAndSave(_arabNum, rqs);

        }

        private string _numValue = "";
        public string NumericValue
        {
            get { return _numValue; }
            set
            {
                _numValue = StationManager.DataStorage.CalculateNumber(_arabNum);;
                OnPropertyChanged("NumericValue");
            }
        }

        private async void Convert(object obj)
        {
             
        //var user = StationManager.CurrentUser;
        string rNumber = StationManager.DataStorage.CalculateNumber(_arabNum);

            var rqs = new Request(_arabNum, rNumber, _date);
            StationManager.DataStorage.CalculateAndSave(_arabNum, rqs);
            

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
