using System;

namespace HashTableDequeRandomizedQueue
{
    public class DequeArray<Item> : IIterator<Item>
    {
        private Item[] deque;
        private int head;
        private int tail;
        private int size = 10;

        public bool HasNext => throw new ArgumentException();
        
        // construct a deque where user choose length

        // construct an empty deque
        public DequeArray()
        {
            
        }

        // is the deque empty?
        public bool IsEmpty()
        {
            throw new ArgumentException();
        }

        // return the number of items on the deque
        public int Size()
        {
            throw new ArgumentException();
        }

        // add the item to the front
        public void AddFirst(Item item)
        {
            throw new ArgumentException();
        }

        // add the item to the back
        public void AddLast(Item item)
        {
            throw new ArgumentException();
        }

        // remove and return the item from the front
        public Item RemoveFirst()
        {
            throw new ArgumentException();
        }

        // remove and return the item from the back
        public Item RemoveLast()
        {
            throw new ArgumentException();
        }

        // resize deque
        private void Resize(int newSize)
        {
            throw new ArgumentException();
        }

        // return an iterator over items in order from front to back
        public IEnumerator<Item> Iterator()
        {
            throw new ArgumentException();
        }

        public Item MoveNext()
        {
            throw new ArgumentException();
        }
    }
}