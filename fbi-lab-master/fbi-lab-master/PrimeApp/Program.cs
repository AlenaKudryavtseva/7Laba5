﻿using System;

namespace PrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var srv = new Prime.Services.PrimeService();

            var prim = srv.PrimeName("Alyona2");

            Console.WriteLine($"PrimeName: {prim}");

           
        }
    }
}
