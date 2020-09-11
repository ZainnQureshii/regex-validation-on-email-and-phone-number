using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex2
{
    public class RegularExpression
    {
        public static bool checkForEmail(String email) 
        {
            bool IsValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
                IsValid = true;
            return IsValid;
 
        }

        public static bool checkForPhone(String phone)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            //Regex r = new Regex(@"^\([+]?\d{1,2}[.-]?)?(\d{3}[.-]?){2}\d{4}");
            if (r.IsMatch(phone))
                IsValid = true;
            return IsValid;

        }
    }
}
