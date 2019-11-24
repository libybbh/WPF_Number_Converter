using System;
using System.Windows;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers
{
    internal static class StationManager
    {
        private static IDbStorage _dataStorage;

        internal static User CurrentUser { get; set; }

        internal static IDbStorage DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(IDbStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }
        
        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }
    }
}
