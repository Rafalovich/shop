using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Client
    {
        public int CId { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string FullName { get; set; }
        public DateTime Added { get; set; }

        public bool ChekLogin()//הפונקציה מבצעת לוגין במערכת ומחזירה אמת או שקר
        {
            return ClientDAL.ChekLogin(this);
        }
        public void Save()
        {
            ClientDAL.Save(this);
        }
        public static List<Client> GetAll()
        {
            return ClientDAL.GetAll();
        }
        public static Client GetById(int Id)
        {
            return ClientDAL.GetById(Id);
        }
        public static int DeleteById(int id)
        {
            return ClientDAL.DeleteById(id);
        }
    }
}