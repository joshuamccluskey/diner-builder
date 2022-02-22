# diner-builder

## Diner Builder

### Contributors AJ Brown, Atasha Sinmeck, Hunde Rufi, Joshua McCluskey

#### Problem Domain

Take restaurant orders in as they come in and reverse the order that they were recieved at the end of the day.

#### Methods

- Intro() - Welcomes user to diner and takes orders and pushes orders to a stack and reverses the order
- PrintStack() - Prints the stack from bottom to top

#### Credit Link to Sources

[Print Stack](https://www.geeksforgeeks.org/print-stack-elements-from-bottom-to-top/)

## Flow Chart

![Diner Flow Chart](/img/diner-flow.png)

## Pseudocode

```Csharp
Main
  Intro();

    static void Intro (){
            int counter = 1;

            WriteLine("Welcome to Tina's Palace! There is a long line ahead of us so let’s get started:)\n ");
            WriteLine("What would like? \t");
            string order ReadLine());

    
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Order " + counter + " : " + order);
            counter++;

            while (order != "QUIT")
            {
                WriteLine("Next! What would you like? \t");
                string order2 (ReadLine());
                if (order2 == "QUIT")
                    break;
                myStack.Push("Order " + counter + " : "+ order2);
                counter++;

                
            }
            }

            PrintStack(myStack);

        
            Console.WriteLine("Reverse Order");
            while (myStack.Count > 0)
            {
                Write(myStack.Pop().ToString());
            }

        

        //Create method to display contents of stack in reverse
        //Credit: https://www.geeksforgeeks.org/print-stack-elements-from-bottom-to-top/
        static void PrintStack(Stack<string> s)
        {
         Console.Write(s)
        }


```
