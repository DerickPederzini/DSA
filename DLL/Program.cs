﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLL list = new DLL();
            list.insertFirst(3);
            list.insertFirst(2);
            list.insertFirst(8);
            list.insertFirst(17);
            list.insertLast(99);
            list.insert(8, 65);
            
            list.display();

        }
    }
}
