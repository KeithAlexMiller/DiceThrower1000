using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        //static int numDiceSides = 0;
        //static int numOfDice = 0;
        //static string dice = "d";
        static void Main(string[] args)
        {
            DiceThrower("10d6");
            DiceThrower("3d20");
            DiceThrower("100d6");
            Console.ReadKey();
        }

        public static void DiceThrower(string input)
        {
            int totalSum = 0;
            int totalRolls = 0;
            int numDice = 0;
            int numSides = 0;

            Random rng = new Random();
            List<string> args = input.Split('d').ToList();
           // int diceRoll = rng.Next(1, (numDiceSides + 1));
            
            for (int i = 0; i < int.Parse(args[0]); i++)
			{
                int rollval = rng.Next(1,int.Parse(args[1])+1);

                Console.WriteLine("Throwing: " + numDice + "d" + numSides);

                totalSum += rollval;
                Console.WriteLine(rng.Next(1,int.Parse(args[1])+1) + " ");



                //pause for effect...
                //  System.Threading.Thread.Sleep(1000);

                //   counter++;
                //
                //      Console.WriteLine("Results: " + total rolls + " ");
			}
            Console.WriteLine("avg: {0}", (totalSum / totalRolls));

        }

            //int counter = 0;
              //  while (counter <= numOfDice)
               // {
                //    Random randomNumberGenerator = new Random();
                 //   int diceRoll = randomNumberGenerator.Next(1, (numDiceSides + 1));

                //    Console.WriteLine("Throwing: " + dice + numDiceSides);

                    //pause for effect...
                  //  System.Threading.Thread.Sleep(1000);

                 //   counter++;
            //
              //      Console.WriteLine("Results: " + diceRoll + " ");
               //   }
    }
}
