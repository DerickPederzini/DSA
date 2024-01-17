using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_StrongPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumNumber(1, "2bbb"));
        }
        public static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int count = 0;
            if (!numbers.ToCharArray().Any(password.Contains))
                count++;
            if (!lower_case.ToCharArray().Any(password.Contains))
                count++;
            if (!upper_case.ToCharArray().Any(password.Contains))
                count++;
            if (!special_characters.ToCharArray().Any(password.Contains))
                count++;
            return Math.Max(6 - n, count);

        }
    }
}
