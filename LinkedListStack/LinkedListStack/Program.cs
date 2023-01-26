using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node
    {
        public float value = 0;
        public Node Next = null;
    }
    class stackinlinkedlist
    {
        Node Head = null;
        //enter data
        public void Push(float a)
        {
            Node n = new Node();
            n.value = a;
            if (Head == null)
                Head = n;
            else
            {
                n.Next = Head;
                Head = n;
            }
        }
        //leave data
        public float Pop()
        {
            if (Head == null)
            {
                float v = Head.value;
                Head = Head.Next;
                return v;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }
    }
    class CMyListStack
    {
        public static void main()
        {
            stackinlinkedlist st = new stackinlinkedlist();
            
            for (int i = 0; i < 3; i++)
                st.Push(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 3; i++)
                Console.WriteLine(st.Pop());
        }
    }
}
