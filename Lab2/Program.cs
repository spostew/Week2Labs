/// Chapter No. 2		Lab No. 2
/// File Name: Lab2.java
/// @author: Spencer Unitt
/// Date:  August 30, 2021
///
/// Problem Statement: Using division and the module operator, determine how many candy bars and gumballs the user can get
/// with n amount of coupons. Show the amount of each and the remainder of coupons the user will have.
/// 
/// 
/// Overall Plan:
/// 1) Create 5 different variables that will hold the value of each item you wish to calculate.
/// 2) Divide the coupons by 10 and store in the number of candy bars variable
/// 3) Determine the number of coupons left by using the module operater with the number of coupons
/// 4) Determine the number of gumballs the same way as above.
/// 5) Display the results of each item to the user in a formated line.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables used to store the values
            int num_coupons = 108, num_coupon_after_candybar, num_coupon_after_gumballs, num_candy_bar, num_gumball;

            // Calculate the number of candy bars
            num_candy_bar = num_coupons / 10;

            // Determines the remainder of the coupons with the module operator
            num_coupon_after_candybar = num_coupons % 10;

            // Calculate the number of gumballs
            num_gumball = num_coupon_after_candybar / 3;

            // Determine the remaining total coupons
            num_coupon_after_gumballs = num_coupon_after_candybar % 3;

            // Displays the results to the user
            Console.WriteLine("Your {0} coupons can be redeemed for {1} candybars and {2} gumballs with {3} coupons leftover", num_coupons, num_candy_bar, num_gumball, num_coupon_after_gumballs);
            Console.ReadLine();
        }
    }
}
