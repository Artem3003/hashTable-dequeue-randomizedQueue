using System;

namespace HashTableDequeRandomizedQueue
{
    public class DequeArray<Item> : IIterator<Item>
    {
        private Item[] deque;
        private int head;
        private int tail;
        private int size = 10;

        public bool HasNext => head <= tail;
        
        // construct a deque where user choose length
        public DequeArray(int size)
        {
            this.deque = new Item[size];
            this.head = size / 2;
            this.tail = head;
        }
        // construct an empty deque
        public DequeArray()
        {
            this.deque = new Item[size];
            this.head = size / 2;
            this.tail = head;
        }

        // is the deque empty?
        public bool IsEmpty()
        {
            return head >= tail;
        }

        // return the number of items on the deque
        public int Size()
        {
            if (tail >= size)
            {
                return tail + 1 - head;
            }
            return tail - head;
        }

        // add the item to the front
        public void AddFirst(Item item)
        {
            if (head == 0)
            {
                Resize(deque.Length * 2);
            }
            deque[head--] = item;
        }

        // add the item to the back
        public void AddLast(Item item)
        {
            if (tail == deque.Length - 1)
            {
                Resize(deque.Length * 2);
            }
            deque[++tail] = item;
        }

        // remove and return the item from the front
        public Item RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            Item item = deque[++head];
            deque[head] = default(Item);
            return item;
        }

        // remove and return the item from the back
        public Item RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            Item item = deque[tail];
            deque[tail--] = default(Item);
            return item;
        }

        // resize deque
        private void Resize(int newSize)
        {
            Item[] newDeque = new Item[newSize];

            int newHead = (newSize - Size()) / 2;
            int newTail = newHead + Size() - 1;

            for (int i = head, j = newHead; i <= tail; i++, j++)
            {
                newDeque[j] = deque[i];                
            }

            deque = newDeque;
            head = newHead;
            tail = newTail;
        }

        // return an iterator over items in order from front to back
        public IEnumerator<Item> Iterator()
        {
            for (int i = head; i <= tail; i++)
            {
                yield return deque[i];
            }
        }

        public Item MoveNext()
        {
            if (HasNext)
            {
                return  deque[head++];
            }
            throw new InvalidOperationException();
        }
    }
}