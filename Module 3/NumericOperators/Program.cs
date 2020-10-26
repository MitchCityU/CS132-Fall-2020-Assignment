using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize and asssign some variables some values 
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            // initialize some more variables and assign some values by 
            // performing calculations on the previously assigned variables 
            float sum = num1 + num2 + num3;
            int subtract = num2 - num1;
            int multiply = num1 * num2;
            float divide = num1 / num3;
            // the modulo operator takes the remainder 
            int modulus = num2 % num1;

            // output the values of the calculations, add the values at the end 
            // of strings to let the user know what values are being outputed 
            Console.WriteLine("Sum of 3 Numbers is: " + sum);
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is: " + divide);
            Console.WriteLine("77 % 20 is: " + modulus);
        }
    }
}
