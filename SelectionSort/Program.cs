﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var selectionSort = new SelectionSort();

            var output =selectionSort.SelectionSorting(new int[] { 7, 3, 9, 4, 2, 2, 11, 10, 6 });

            foreach( var i in output )
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
