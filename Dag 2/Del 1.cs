using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opponentScorE = 0, myScore = 0;

            int Str2Int(string c)
            {
                switch (c)
                {
                    case "A": return 1;
                    case "B": return 2;
                    case "C": return 3;

                    case "X": return 1;
                    case "Y": return 2;
                    case "Z": return 3;

                }
                return 0;
            }
            
            List<string> lines = System.IO.File.ReadAllLines(@"C:\Users\Simon\Source\Repos\AoC-2022\Dag 2\dataDay2.txt").ToList();
            List<string> linesInt = new List<string>();

            foreach (string line in lines)
            {
                string[] split = line.Split(' ');
                linesInt.Add($"{Str2Int(split[0])} {Str2Int(split[1])}");
            }

            foreach (string item in linesInt)
            {
                string[] split = item.Split(' ');


                //dec values int.
                int num1 = int.Parse(split[0]); int num2 = int.Parse(split[1]);

                //methods
                void Win1()
                {
                    opponentScorE += 6 + num1;
                    myScore += num2;
                }

                void Win2()
                {
                    myScore += 6 + num2;
                    opponentScorE += num1;
                }
                //

                //spellogik
                if(num1 == num2)
                {
                    opponentScorE += num1 + 3;
                    myScore += num2 + 3;
                }
                else
                {
                    if(num1 == 1 && num2 == 2) {Win2();}
                    if(num1 == 1 && num2 == 3) {Win1();}
                    if(num1 == 2 && num2 == 1) {Win1();}
                    if(num1 == 2 && num2 == 3) {Win2();}
                    if(num1 == 3 && num2 == 1) {Win2();}
                    if(num1 == 3 && num2 == 2) {Win1();}
                    
                }
            }
            Console.WriteLine(opponentScorE);
            Console.WriteLine(myScore);

        }
    }
}
