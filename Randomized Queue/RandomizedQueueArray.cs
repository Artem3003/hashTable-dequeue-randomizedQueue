using System;
using System.Collections;

namespace HashTableDequeRandomizedQueue
{
    public class RandomizedQueueArray<Item> : IEnumerable<Item> 
    {
        
        private Item[] randomizedQueue;
        private int size = 10;
        private int tail;
        public Random random;
        // construct an empty randomized queue
        public RandomizedQueueArray()
        {
            this.randomizedQueue = new Item[size];
            this.tail = 0;
            random = new Random();
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            return randomizedQueue.Length == 0;
        }

        // return the number of items on the randomized queue
        public int Size()
        {
            return tail;
        }

        // add the item
        public void Enqueue(Item item)
        {
            if (Size() > size)
            {
                Resize(Size() + 5);   
            }
            randomizedQueue[tail++] = item;
        }

        // remove and return a random item
        public Item Dequeue()
        {
            int index = random.Next(0, tail + 1);
            Item deletedItem = randomizedQueue[index];

            randomizedQueue = randomizedQueue.Except(new Item[] {deletedItem}).ToArray();
            
            tail--;
            return deletedItem;
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            int index = random.Next(0, tail);
            return randomizedQueue[index];
        }

        private void Resize(int newSize)
        {
            Item[] newRandomizedQueue = new Item[newSize];

            for (int i = 0; i <= randomizedQueue.Length; i++)
            {
                newRandomizedQueue[i] = randomizedQueue[i];                
            }

            randomizedQueue = newRandomizedQueue;
        }

        // return an independent iterator over items in random order
        public IEnumerator<Item> Iterator()
        {
            for (int i = 0; i < tail; i++)
            {
                yield return randomizedQueue[i];
            }
        }

        public IEnumerator<Item> GetEnumerator()
        {
            for (int i = 0; i < tail; i++)
            {
                yield return randomizedQueue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < tail; i++)
            {
                yield return randomizedQueue[i];
            }
        }
    }
}