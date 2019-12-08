namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation
{
    internal enum ViewType
    {
        SignIn,
        SignUp,
        Main,
        UserList
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
