﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIoC
{
    public class Perro : IAnimal
    {
        public void Dormir()
        {
            Console.WriteLine( "El perro duerme!" );
        }
    }
}