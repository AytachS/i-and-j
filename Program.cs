using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Task();    //The code has to be placed in a seperate method to be able to be repeated!

        }

        static void Task()
        {
            Console.Clear();
            Console.WriteLine("Input i: ");
            int i = Convert.ToInt32(Console.ReadLine()); //Get i
            Console.WriteLine("Input j: ");
            int j = Convert.ToInt32(Console.ReadLine()); //Get j

            if (i == j) //Check if i and j  are equal
            {
                Console.WriteLine("i is equal to j");
            }
            else if (j > i) //If i is smaller than j, increase its value
            {
                while (i < j + 1) //"j + 1" because otherwise the loop ends before we print the final value of 'i'!
                {
                    Console.WriteLine("i = {0}", i);
                    i++;
                }
                Console.WriteLine("i is equal to j");
            }
            else //If i is larger than j, decrease its value
            {
                while (i > j - 1) //"j - 1" because otherwise the loop ends before we print the final value of i!
                {
                    Console.WriteLine("i = {0}", i);
                    i--;
                }
                Console.WriteLine("i is equal to j");
            }

            Console.WriteLine("Run again? (y/n)"); //Ask about repeating the code
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                    Task(); // answer = yes => Repeat the code (Call the method again)
                    break;
                case "n":
                     //Returns to Main();
                    break;
                default:
                     //Returns to Main();
                    break;
            }


        }
    }
}
