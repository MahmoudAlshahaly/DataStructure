using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ArrayQueue
    {
        int Front = -1;
        int Rear = -1;
        float[] arr = new float[4];

        public void Enter(float a)
        {
            if (!isFull())
            {
                arr[++Rear] = a;
            }
            else
            {
                Console.WriteLine("Unable to Enter");
            }
        }

        public float Leave()
        {
            if (!isEmpty())
            {
                return arr[++Front];
            }
            else
            {
                Console.WriteLine("Queue is Full");
                return -1;
            }
        }
        public bool isEmpty()
        {
            return (Rear == Front);
        }
        public bool isFull()
        {
            if (Rear == arr.Length - 1 && Front == arr.Length - 1)
            {
                Rear = Front = -1;
                return true;
            }
            return (Rear == arr.Length - 1);
        }
    }
    class program
    {
        public static void Main()
        {
           ArrayQueue q = new ArrayQueue();
            for (int i = 0; i < 4; i++)
                q.Enter(i);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(q.Leave());
        }
       

    }
}
