﻿using System;

namespace ClassCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            Console.Read();
        }
    }

}
