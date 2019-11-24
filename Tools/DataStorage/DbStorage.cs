using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage
{
    internal class DbStorage : IDbStorage
    {
        public void AddUser(User user)
        {
            try { 
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();

            User usr = new User(user.FirstName, user.LastName, user.Email,user.Login, user.Password);
            ServiceReference1.User usr1 = new ServiceReference1.User();

            usr1.Name = usr.FirstName;
            usr1.Surname = usr.LastName;
            usr1.Email = usr.Email;
            usr1.Login = usr.Login;
            usr1.Password = usr.Password;

            sc.AddUser(usr1);
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
                ServiceReference1.Service1Client sr = new ServiceReference1.Service1Client();

                User user = new User(sr.checkIfUserExists(login, password).Name, sr.checkIfUserExists(login, password).Name,
                    sr.checkIfUserExists(login, password).Email, sr.checkIfUserExists(login, password).Login, sr.checkIfUserExists(login, password).Password);

                return user;
                //  sr.checkIfUserExistsLog(login) && sr.checkIfUserExistsPas(password);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UserExists(string login, string password)
        {
                ServiceReference1.Service1Client sr = new ServiceReference1.Service1Client();
                return sr.checkIfUserExistsBool(login,password);

            }


        public string CalculateNumber(int arab)
        {

            ServiceReference1.Service1Client sr = new ServiceReference1.Service1Client();

            return sr.ArabicToRoman(arab);
        }


            public void CalculateAndSave(int arab,Request req) {

            try
            {
                ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();

                //   Request r = new Request(req.NumToCon, req.NumAfterConreq.NumAfterCon);
              //ServiceReference1.Request req1 = new ServiceReference1.Request();

              //  req1.ArabicNumber = req.NumToCon;
              //  req1.RomanNumber = req.NumAfterCon;
              //  req1.Time = req.Time;

               
              //  sc.AddRequest(r);


                Request reqs = new Request(req.NumToCon, req.NumAfterCon, req.Time);
                ServiceReference1.Request req1 = new ServiceReference1.Request();

                req1.ArabicNumber= req.NumToCon;
                req1.RomanNumber = req.NumAfterCon;
                req1.Time = req.Time;
           

                sc.AddRequest(req1);









            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
    }
    

