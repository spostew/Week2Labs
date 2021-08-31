/// Chapter No. 2		Lab No. 1
/// File Name: Lab1.java
/// @author: Spencer Unitt
/// Date:  August 30, 2021
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum of these three numbers.
/// Then multiply the three numbers used and calculate the product of the three numbers. 
/// Finally divide the product with the sum and display the results of each equation to the user.
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum and product of the integers
/// 4) Determine the quotient of the product and the sum
/// 5) Display the results of each equation to the user
/// 

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

            // declare three integer variables, the sum and the product
            int n1, n2, n3, sum, product;
            // the divide varible will be a double to show nums after the decimal
            double divide;

            // Obtains the nums the user enters
            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;
            // calculate the product of the three numbers
            product = n1 * n2 * n3;
            // determine the quotient of the product and sum
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
