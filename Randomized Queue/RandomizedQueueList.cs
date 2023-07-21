using System;
using System.Collections;

namespace HashTableDequeRandomizedQueue
{
    class RandomizedQueueList<Item> : IEnumerable<Item> 
    {
        private LinkedList<Item> randomizedQueue;

        // construct an empty randomized queue
        public RandomizedQueueList()
        {
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            throw new ArgumentException();
        }

        // return the number of items on the randomized queue
        public int Size()
        {
            throw new ArgumentException();
        }

        // add the item
        public void Enqueue(Item item)
        {
            throw new ArgumentException();
        }

        // remove and return a random item
        public Item Dequeue()
        {
            throw new ArgumentException();
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            throw new ArgumentException();
        }

        // return an independent iterator over items in random order
        public IEnumerator<Item> Iterator()
        {
            throw new ArgumentException();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new ArgumentException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new ArgumentException();
        }
    }
}