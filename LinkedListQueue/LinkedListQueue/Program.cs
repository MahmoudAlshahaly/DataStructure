using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class QueueLinked
    {
        Node Head = null;
        public void Push(float a)
        {
            Node n = new Node();
            n.value = a;

            if (Head == null)
            {
                Head = n;
            }
            else
            {
                n.Next = Head;
                Head = n;
            }
        }
        public float Pop()
        {
            float v = -1;
            if (Head!=null)
            {
                if (Head.Next == null)
                {
                    v = Head.value;
                    Head = null;
                }
                else
                {
                    Node n = Head;
                    while (n.Next.Next == null)
                    {
                        n = n.Next;
                    }
                    v = n.Next.value;
                    n.Next = null;
                }
            }
            else
                Console.WriteLine("Stack is Empty");
            return v;
        }
       
    }
    class Node
    {
        public float value = 0;
        public Node Next = null;
    }
    class CMyListQueue
    {
        public static void Main()
        {
            int n = 4;
            QueueLinked st = new QueueLinked();
            for (int i = 0; i < n; i++)
                st.Push(int.Parse(Console.ReadLine()));

            for (int i = 0; i < n; i++)
                Console.WriteLine(st.Pop());
        }

       
    }

}
