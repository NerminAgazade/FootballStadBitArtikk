using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballStadion
{
    class Excentios
    {
        public static bool IsEmpty(string[] arr, string text)
        {
            foreach (var array in arr)
            {
                if (array == text)
                {
                    return false;
                }
            }
            return true;
        }
        public void DisplaySomething(string s)
        {
            System.Console.WriteLine(s);
        }
        public static string HasMe(string pass)
        {
            byte[] myByte = new ASCIIEncoding().GetBytes(pass);
            byte[] hashByte = new StringComparison().ComputeHash(myByte);
            string hashString = new ASCIIEncoding().GetString(hashByte);
            return hashString;
        }
    }
}
