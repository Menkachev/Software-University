﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var sentimeters = inches * 2.54;

            Console.Write("Sentimeters = ");
            Console.WriteLine(sentimeters);
        }
    }
}
