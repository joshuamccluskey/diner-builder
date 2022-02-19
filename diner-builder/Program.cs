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

            DisplayStack(myStack);
            PrintStack(myStack);


            while (myStack.Count > 0)
            {
                WriteLine(myStack.Pop().ToString());
            }

        }
        //Create method to display contents of stack in reverse
        public static void PrintStack(Stack<string> s)
        {
            // If stack is empty
            if (s.Count == 0)
                return;

            // Pop the top element
            s.Pop();

            // Extract top of the stack
            string x = s.Peek();
            // Print the current top
            // of the stack i.e., x
            Write(x + " ");

            // Proceed to print
            // remaining stack
            PrintStack(s);

            // Push the element back
            s.Push(x);
        }
        public static void DisplayStack(Stack<string> s)
        {
            // Create another stack
            Stack<string> s1 = new Stack<string>();

            // Until stack is empty
            while (s.Count > 0)
            {
                s1.Push(s.Peek());

                // Print the element
                Console.Write(s1.Peek() + " ");
                s.Pop();
            }
        }
    }
}
