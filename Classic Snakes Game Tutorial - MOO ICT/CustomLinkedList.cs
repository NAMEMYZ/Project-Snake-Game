using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classic_Snakes_Game
{
    public class CustomLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        private Node head;
        private Node tail;

        public void Add(T data)
        {
            Node newNode = new Node { Data = data, Next = null };

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void Remove(T data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                {
                    if (previous == null)
                    {
                        head = current.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }

                    return;
                }

                previous = current;
                current = current.Next;
            }
        }

        public IEnumerable<T> GetAll()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

}
