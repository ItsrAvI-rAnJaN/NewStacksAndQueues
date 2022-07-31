using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stacks
    {
         internal Node Head;
        public Stacks()
        {
            this.Head = null;
        }
        public void Push(int Value)
        {
            Node NewNode=new Node(Value);

            if (this.Head == null)
            {
                NewNode.Next = null;
            }
            else
            {
                NewNode.Next = Head;
            }
            this.Head = NewNode;
            Console.WriteLine("{0} is Added to the Stack",NewNode.Value);
        }
        public void Display()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("The Stack is :-");
            Console.Write("Head:-");
            Node TempNode = this.Head;

            while(TempNode != null)
            {
                Console.WriteLine(TempNode.Value+" ");
                TempNode = TempNode.Next;
            }

        }
    }
}
