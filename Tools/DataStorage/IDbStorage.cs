using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage
{
    internal interface IDbStorage
    {
        bool UserExists(string login, string password);

        User GetUserByPasswordLogin(string login, string password);

        User GetUserByLogin(string login);

        void AddUser(User user);
        void CalculateAndSave(int arab, User user);

    }
}