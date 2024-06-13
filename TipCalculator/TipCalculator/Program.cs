using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int percentage = 0;

            Console.WriteLine("Welcome to the Tip Calculator");

            //Repeat
            do
            {
                //1.Get the bill amount
                Console.WriteLine("Enter bill amount:");
                string s = Console.ReadLine();
                // convert to a double
                double billAmount = Convert.ToDouble(s);

                //2.Get the tip percentage
                while (true)
                {
                    Console.WriteLine("Enter tip percentage:");
                    string s2 = Console.ReadLine();
                    // convert to a double
                    percentage = Convert.ToInt32(s2);

                    if (percentage >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tip rate cannot be negative");
                    }
                }

                //3.Calculate the total amount
                double totalAmount = billAmount +
                    (percentage / 100.0) * billAmount;

                //4.Display the total amount
                Console.WriteLine("The total amount of your bill " +
                    "is: {0}", totalAmount);

                //Until the user wants to stop
                Console.WriteLine("More calculations? (yes/no)");
                answer = Console.ReadLine();

            } while (answer.ToLower() != "no");

            Console.WriteLine("Goodbye!");
            Console.ReadLine(); // Keeps the console window open
        }
    }
}
