using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLL list = new CLL();
            list.insert(9);
            list.insert(5);
            list.insert(21);
            list.insert(24);
            list.insert(6);
            list.insert(7);

            list.delete(7);

            list.display();
        }
    }
}
