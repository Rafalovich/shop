using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Users
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int CityId { get; set; }
        public string Addres { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public DateTime RegisDate { get; set; }
        public void Save()
        {
            UsersDAL.Save(this);
        }
        public static List<Users> GatAll()
        {
            return UsersDAL.GetAll();
        }
        public static Users GetById(int id)
        {
            return UsersDAL.GetById(id);
        }
    }
}