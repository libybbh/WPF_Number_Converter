using System;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage
{
    internal class DbStorage : IDbStorage
    {
        ServiceReference1.Service1Client sr = new ServiceReference1.Service1Client();

        public void AddUser(User user)
        {
            try { 

            User usr = new User(user.FirstName, user.LastName, user.Email,user.Login, user.Password);
            ServiceReference1.User usr1 = new ServiceReference1.User();

            usr1.Name = usr.FirstName;
            usr1.Surname = usr.LastName;
            usr1.Email = usr.Email;
            usr1.Login = usr.Login;
            usr1.Password = usr.Password;

            sr.AddUser(usr1);
            }
            catch(Exception ex)
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
                return null;
            }
        }


        public bool UserExists(string login, string password)
        {
                return sr.checkIfUserExistsBool(login,password);

            }

            public void CalculateAndSave(int arab, User user) {

            try
            {
                Request reqs = new Request(arab," ", DateTime.Now);//client request
                ServiceReference1.Request req1 = new ServiceReference1.Request();//server request

                req1.ArabNumber= reqs.ArabNumber;
                req1.RomanNumber = reqs.RomanNumber;
                req1.Time = reqs.Time;

                sr.AddUserRequest(user.Login, arab);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
    }
    

