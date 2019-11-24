using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Views
{
    public partial class MainView : UserControl, INavigatable
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); 

        }
        private void NumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);

        }


        private static bool IsTextNumeric(string str)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^0-9]");
            return reg.IsMatch(str);

        }
    }
}
