﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeShop.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl = new ClassLibrary1.Class1();

            var num = cl.Add(1, 2);
            Console.WriteLine("EST " + num.ToString());
        }
    }
}
