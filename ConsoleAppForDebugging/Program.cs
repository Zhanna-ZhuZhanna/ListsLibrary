﻿using System;
using DataStructures;
using DataStructures.LList;
namespace ConsoleAppForDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(list.ToString());
            list.Add(new int[] { 5, 6, 7 });
            Console.WriteLine(list.ToString());
        }
    }
}
