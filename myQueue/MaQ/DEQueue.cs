using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaQ
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev{ get; set; }
    }

    public class DEQueue<T>
    {
        
        Node<T> first;
        Node<T> last; 
        int count;

        public void pushBack(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = last;
           last= node;
            if (count == 0)
                first = last;
            else
            {
                temp.Next = last;
                last.Prev = temp;
            }
            count++;
        }

        public void pushFront(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = first;
            first = node;
            if (count == 0)
                last = first;
            else
            {
                temp.Prev = first;
                first.Next = temp;
            }
            count++;
        }

        public T front()
        {
            if (count != 0)
            {
                return first.Data;
            }
            else
                throw new InvalidOperationException();
        }
        public T back()
        {
            if (count != 0)
            {
                return last.Data;
            }
            else
                throw new InvalidOperationException();
        }
        public int size() {
            return count;
        }
        public void clear() {
            count = 0;
        }
        public T popFront()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = first.Data;
            first = first.Next;
            count--;
            return output;
        }
        public T popBack()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = last.Data;
            last = last.Prev;
            count--;
            return output;
        }


        public T[] toArray()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T[] output = new T[count];
            Node<T> temp = first;
            for (int i = 0; i < count; i++) {
                output[i] = temp.Data;
                temp = temp.Next;
            }
            return output;
        }



    }
}
