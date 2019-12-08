using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage
{
    internal class DbStorage : IDbStorage
    {
        ServiceReference1.Service1Client sr = new ServiceReference1.Service1Client();

        public void AddUser(User user)
        {
            try
            {

                User usr = new User(user.FirstName, user.LastName, user.Email, user.Login, user.Password);
                ServiceReference1.User usr1 = new ServiceReference1.User();

                usr1.Name = usr.FirstName;
                usr1.Surname = usr.LastName;
                usr1.Email = usr.Email;
                usr1.Login = usr.Login;
                usr1.Password = EncodePasswordToBase64(usr.Password);

                sr.AddUser(usr1);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public User GetUserByPasswordLogin(string login, string password)
        {
            try
            {
                User user = new User(sr.checkIfUserExists(login, password).Name, sr.checkIfUserExists(login, password).Name,
                    sr.checkIfUserExists(login, password).Email, sr.checkIfUserExists(login, password).Login, sr.checkIfUserExists(login, password).Password);

                return user;

            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }


        public User GetUserByLogin(string login)
        {
            try
            {

                User user = new User(sr.checkIfUserExistsByLogin(login).Name, sr.checkIfUserExistsByLogin(login).Name,
                    sr.checkIfUserExistsByLogin(login).Email, sr.checkIfUserExistsByLogin(login).Login, sr.checkIfUserExistsByLogin(login).Password);

                return user;

            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }


        public bool UserExists(string login, string password)
        {
            return sr.checkIfUserExistsBool(login, password);

        }

        public string CalculateAndSave(int arab, User user)
        {
            Request reqs = new Request(arab, " ", DateTime.Now);
            ServiceReference1.Request req1 = new ServiceReference1.Request();
            string romanFinal = sr.AddUserRequest(user.Login, arab);
            reqs.ArabNumber = req1.ArabNumber;
            reqs.RomanNumber = req1.RomanNumber;
            reqs.Time = req1.Time;
            return romanFinal;

        }

        public ObservableCollection<Request> GetHistoryByLogin(string login)
        {
                try {
                    ObservableCollection<Request> requestList = new ObservableCollection <Request>();

                    foreach (var r in sr.GetUsersRequests(login))
                    {
                        Request reqClient = new Request();
                        reqClient.ArabNumber = r.ArabNumber;
                        reqClient.RomanNumber = r.RomanNumber;
                        reqClient.Time = r.Time;
                        requestList.Add(reqClient);
                    }

                    ObservableCollection<Request> historyList = new ObservableCollection<Request>();

                    foreach (var item in requestList)
                    {
                        historyList.Add(new Request(item.ArabNumber, item.RomanNumber, item.Time));
                    }

                    return historyList;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return null;
                }
            }


        public string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

    }
}


