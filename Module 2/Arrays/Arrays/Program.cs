using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // creating a new array of type integer named 'numbers'
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            /*     for (int i = 0; i < numbers.Length; i++)
                 {
                     Console.WriteLine(numbers[i] + " ");
                 }  
            foreach(int number in numbers)
                 {
                     Console.Write(number + " ");
                 }  */
            string[] Sentance = new string[4];
            Sentance[0] = "This";
            Sentance[1] = "is";
            Sentance[2] = "a";
            Sentance[3] = "string";

            for(int j = 0; j < Sentance.Length; j++)
            {
                Console.Write(Sentance[j] + " "); 
            }


        }
    }
}
