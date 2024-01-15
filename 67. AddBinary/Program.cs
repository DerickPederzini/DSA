using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddBinary("11", "1");
        }

        public static string AddBinary(string a, string b)
        {
            string res = "";
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                carry = sum > 1 ? 1 : 0;
                res += (sum % 2).ToString();
            }
            if (carry != 0) res += (carry).ToString();
            return res.Reverse().ToString();

        }
    }
}
