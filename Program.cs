// Henrique Correa
//ISM4300.901S20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask for user input
            Console.WriteLine("Please, enter an integer value between 1 and 100.");

            //Use the try catch to ensure user's input is within 
            try
            {
                string value = Console.ReadLine();

                int input_number = int.Parse(value);

                if ((input_number > 0) && (input_number < 101))
                {
                    for (int a = 1; a <= input_number; a++)

                        // If the value of user input is between 1 and 100, execute a For Loop                      
                    Console.WriteLine("You have entered " + input_number.ToString() + "." + " This is the current integer value in the loop: " + a.ToString());                       
                    Console.WriteLine("Press any key to exit the console");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please, restart the console and enter a valid integer");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Press any key to exit the console");
                Console.ReadKey(true);
            }
            }
        }
}
