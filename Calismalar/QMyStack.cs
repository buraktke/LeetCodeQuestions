using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class QMyStack
    {
        ArrayList values = new ArrayList();

        public QMyStack()
        {

        }

        public void Push(int x)
        {
            values.Add(x);
        }

        public int Pop()
        {
            int x = (int)values[(values.Count - 1)];
            values.RemoveRange(values.Count - 1, 1);
            return x;
        }

        public int Top()
        {
            int x = (int)values[(values.Count - 1)];
            return x;
        }

        public bool Empty()
        {
            return values.Count != 0 ? false : true;
        }

    }

    internal class QMyStack2
    {
        Queue<int> queue = new Queue<int>();

        public QMyStack2()
        {

        }

        public void Push(int x)
        {
            queue.Enqueue(x);

            for (int i = 0; i < queue.Count - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
