using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public string PDesc { get; set; }
        public string PicName { get; set; }
        public void Save()
        {
            ProductDAL.Save(this);
        }
        public static List<Product> GetAll()
        {
            return ProductDAL.GetAll();
        }
        public static Product GetById(int Id)
        {
            return ProductDAL.GetById(Id);
        }
        public static int DeleteById(int Id)
        {
            return ProductDAL.DeleteById(Id);
        }
    }
}