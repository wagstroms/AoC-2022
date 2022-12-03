using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AoC_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = System.IO.File.ReadAllLines(@"C:\Users\Simon\OneDrive\VS\TestWPF\AoC 3\AoC 3\TextFile1.txt").ToList();
            string LCL = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int totalPriority = 0;

            for (int i = 0; i < lines.Count() - 2; i += 3)
            {
                string backpack1 = lines[i];
                string backpack2 = lines[i + 1];
                string backpack3 = lines[i + 2];

                foreach (char x in backpack1)
                {
                    if (backpack2.Contains(x) && backpack3.Contains(x))
                    {
                        totalPriority += LCL.IndexOf(x) + 1;
                        break;
                    }
                }
            }

            Console.WriteLine("Sammanställda prioriteten av alla badges : " + totalPriority);

        }
    }
}
