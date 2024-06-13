using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Category
    {
        public int CategId { get; set; }
        public string CategName { get; set; }
        public string CategDesc { get; set; }
        public string CategPicName { get; set; }
        public int CategFather { get; set; }
        public void Save()
        {
            CategoryDAL.Save(this);
        }
        public static List<Category> GetAll()
        {
           return CategoryDAL.GetAll();
        }
        public static Category GetById(int id)
        {
            return CategoryDAL.GetById(id);
        }
        public static int DeleteById(int id)
        {
            return CategoryDAL.DeleteById(id);
        }
    }
}