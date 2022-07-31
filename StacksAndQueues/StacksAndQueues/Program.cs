using System;

namespace StacksAndQueues
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t#######################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO STACKS AND QUEUES PROGRAM");
            Console.WriteLine("\t\t\t\t#######################################################");

            int Choice;
            do
            {
                Console.WriteLine("\n0.Exit");
                Console.WriteLine("1.Create Stack 56->30->70->");
                Console.Write("\nEnter the Choice of Question Number : ");
                Choice=Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Stacks objStack = new Stacks();
                        objStack.Push(70);
                        objStack.Push(56);
                        objStack.Push(30);
                        objStack.Display();
                        break;

                }
            }
            while(Choice!=0);
            Console.ReadKey();

        }
    }
}