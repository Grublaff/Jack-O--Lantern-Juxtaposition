using System;
using System.Collections.Generic;

namespace Jack_O__Lantern_Juxtaposition{
    class Program{
        static void Main(string[] args){
            string[] input = Console.ReadLine().Split(" ");
            int[] inputInt = Array.ConvertAll(input, int.Parse);
            int total = 1;
            foreach (int element in inputInt){
                total *= element;
            }
            Console.WriteLine(total);
        }
    }
}
