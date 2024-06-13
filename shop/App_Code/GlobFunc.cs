using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shop
{
    public class GlobFunc
    {
        public static string GetRandStr(int length)
        {
            Random rnd = new Random();
            string RetStr = "";
            int index ;
            string str = "abcdefghijklmnopqrstuvwxyz0123456789@";
            for (int i = 0; i < length; i++)
            {
                index = rnd.Next(str.Length);
                RetStr += str[index];
                
            }
            return RetStr;
        }
    }
}