using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DVLD_version1.class_Helper
{
    public class clsFunsHelper
    {
        public static string GetReasonById(int id)
        {
       
            switch (id)
            {
                case 1:return "FirstTime"; 
                case 2:return "Renew";
                case 4:return "Replacement for Damaged";
                case 3:return "Replacement for Lost";
                default:return "";
            }
        }
    }
}
