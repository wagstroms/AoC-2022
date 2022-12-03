using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = System.IO.File.ReadLines(@"C:\Users\Simon\Source\Repos\AoC-2022\Dag 1\dataDay1.txt").ToList();
            List<int> dataInt = new List<int>();
            int tempSum = 0;

            foreach(string s in data)
            {
                if (int.TryParse(s, out int tempData)) { tempSum += tempData; }
                else { dataInt.Add(tempSum); tempSum = 0; }
            }

            Console.WriteLine("Most calories : " + dataInt.Max());

            //sort list of caloriers.
            dataInt.Sort();

            Console.WriteLine("The highest three calories are : " + dataInt[dataInt.Count - 1] + " " + dataInt[dataInt.Count - 2] + " " + dataInt[dataInt.Count - 3]);
            Console.WriteLine("These summed give us a total of : " + (dataInt[dataInt.Count - 1] + dataInt[dataInt.Count - 2] + dataInt[dataInt.Count - 3] + " Calories!"));
        }
    }
}

