using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then a second number and finally, a third number: ");

            // declare two integer variables
            int n1, n2, n3, sum, product;
            double divide;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            divide = product / (double)sum;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is: " + sum);
        
            Console.WriteLine("The product of those three numbers is: " + product);
            
            Console.WriteLine("The divsion of the sum / the product is: " + divide);
           
            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
