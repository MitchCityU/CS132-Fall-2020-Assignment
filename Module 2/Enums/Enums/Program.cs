﻿using System;

namespace Enums
{
    class Program
    {
        enum Gender {Male, Female, Other};
        enum Age { Young, Middle, Old};
        enum Hair {  Long, Short, Bald};
        enum Height { Tall, Short};
        static void Main(string[] args)
        {
            Console.WriteLine("I am a " + Gender.Male);
            Console.WriteLine("My Age is " + Age.Young); 
            Console.WriteLine("My Hair is " + Hair.Short); 
            Console.WriteLine("My Height is " + Height.Short);
        }
    }
}
