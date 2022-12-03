using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = System.IO.File.ReadAllLines(@"C:\Users\Simon\OneDrive\VS\TestWPF\AoC 3\AoC 3\TextFile1.txt").ToList();
            List<char> charsFound = new List<char>();
            int totalPriority = 0;


            foreach (string x in lines)
            {
                string firstHalf = x.Substring(0, x.Length / 2);
                string scndHalf = x.Substring(x.Length / 2, x.Length / 2);

                foreach (char z in firstHalf)
                {
                    if (scndHalf.Contains(z))
                    {
                        Console.WriteLine($"Found {z}");
                        charsFound.Add(z);
                        break;
                    }
                }

            }

            void Values(char x)
            {
                string LCL = "abcdefghijklmnopqrstuvwxyz";
                string CL = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (LCL.Contains(x))
                {
                    totalPriority += LCL.IndexOf(x) + 1;
                }
                else if (CL.Contains(x))
                {
                    totalPriority += 27 + CL.IndexOf(x);
                }

            }


            Console.WriteLine($"Found {charsFound.Count} chars");

            foreach (char foundChar in charsFound)
            {
                Values(foundChar);
            }

            Console.WriteLine(totalPriority);
        }
    }
}
