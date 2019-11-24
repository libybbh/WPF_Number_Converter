using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage
{
    internal interface IDbStorage
    {
        bool UserExists(string login, string password);

        User GetUserByPasswordLogin(string login, string password);

        void AddUser(User user);

        // void AddRequest(Request req,string login);

        void CalculateAndSave(int arab, Request req);

        string CalculateNumber(int arab);


}
}