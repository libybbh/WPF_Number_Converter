﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels.Authentication
{
    internal class SignInViewModel:BaseViewModel
    {
        #region Fields
        private string _login;
        private string _password;

        #region Commands
        private ICommand _signInCommand;
        private ICommand _toSignUpCommand;
        private ICommand _closeCommand;
        #endregion
        #endregion

        #region Properties
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return StationManager.DataStorage.EncodePasswordToBase64(_password); }
            set
            {
                _password = StationManager.DataStorage.EncodePasswordToBase64(value);
                OnPropertyChanged();
            }
        }

        #region Commands

        public ICommand SignInCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand =
                           new RelayCommand<object>(SignInImplementation, CanSignInExecute));
            }
        }

        public ICommand ToSignUpCommand
        {
            get
            {
                return _toSignUpCommand ?? (_toSignUpCommand = new RelayCommand<object>(ToSignUpImplementation));
            }
        }

        public ICommand CloseCommand
        {
            get
            {
                return _closeCommand ?? (_closeCommand = new RelayCommand<object>(CloseImplementation));
            }
        }

        #endregion
        #endregion
        private bool CanSignInExecute(object obj)
        {
            return !String.IsNullOrWhiteSpace(_login) && !String.IsNullOrWhiteSpace(_password);
        }

        private async void SignInImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            var result = await Task.Run(() =>
            {
                Thread.Sleep(1000);
                User currentUser;

                currentUser = StationManager.DataStorage.GetUserByPasswordLogin(_login, _password);
                if (currentUser == null)
                {
                    MessageBox.Show(
                        $"Sign In failed fo user {_login}. Reason:{Environment.NewLine}User does not exist.");
                    return false;
                }
                if (!currentUser.CheckPassword(_password))
                {
                    MessageBox.Show($"Sign In failed fo user {_login}. Reason:{Environment.NewLine}Wrong Password.");
                    return false;
                }
                StationManager.CurrentUser = currentUser;
                MessageBox.Show($"Sign In successfull fo user {_login}.");
                return true;
            });
            LoaderManager.Instance.HideLoader();
            if (result)
                NavigationManager.Instance.Navigate(ViewType.Main);
        }

        private void ToSignUpImplementation(object obj)
        {
            NavigationManager.Instance.Navigate(ViewType.SignUp);
        }

        private void CloseImplementation(object obj)
        {
            StationManager.CloseApp();
        }


        
    }
}
