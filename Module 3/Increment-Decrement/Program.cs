using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  for(int a = 0; a <= 10; a++)
            { // create a for loop with 10 iterations
              // initialize an integer a and use the + operator to
              // make an iterator 
                Console.WriteLine(a);
                // write the value of the variable to the console 
            }  */

            int c = 16; // initialize an integer to the value 16, the value should be 
            // set 1 higher than the value being counted down from since C# starts 
            // counting at 0
            for(int b = 0; b <= 14; b++) // create a for loop with 14 iterations, do this because the program runs once and prints the value and then 
                // iterates 
            {
                c = c - 1;  // subtract 1 from the variable c for each iteration 
                Console.WriteLine(c);  //write the value of the variable c to the console
            }

        }
    }
}
