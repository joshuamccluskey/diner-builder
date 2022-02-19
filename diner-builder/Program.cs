using System.IO;
using System.Collections.Generic;
using System;
using static System.Console;

namespace HW2_Pair
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Intro();
        }


        static void Intro ()
        {
            // Create a list for the menu 
            //Intro
            WriteLine("Welcome to Tina's Palace! There is a long line ahead of us so let’s get started:)\n ");
            WriteLine("What would like? \t");
            string order = Convert.ToString(ReadLine());

            // Create a queue to store responses 
            Stack<string> myStack = new Stack<string>();
            myStack.Push(order);
            //
            while (order != "QUIT")
            {
                WriteLine("Next! What would you like? \t");
                string order2 = Convert.ToString(ReadLine());
                myStack.Push(order2);


                if (order2 == "QUIT")
                    break;

            }

            PrintStack(myStack);



            while (myStack.Count > 0)
            {
                WriteLine(myStack.Pop().ToString());
            }

        }
        //Create method to display contents of stack in reverse
        static void PrintStack(Stack<string> s)
        {
            // If stack is empty then return
            if (s.Count == 0)
                return;

            string x = s.Peek();

            // Pop the top element of the stack
            s.Pop();

            // Recursively call the function PrintStack
            PrintStack(s);

            // Print the stack element starting
            // from the bottom
            Console.Write(x + " ");

            // Push the same element onto the stack
            // to preserve the order
            s.Push(x);
        }
    }
}
