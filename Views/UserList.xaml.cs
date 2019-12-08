﻿using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Views
{
    /// <summary>
    /// Логика взаимодействия для UserList.xaml
    /// </summary>
    public partial class UserList : INavigatable
    {
        public UserList()
        {
            InitializeComponent();
            DataContext = new UserListViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
