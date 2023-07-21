using System;
using System.Collections;

namespace HashTableDequeRandomizedQueue
{
    class RandomizedQueueList<Item> : IEnumerable<Item> 
    {
        private LinkedList<Item> randomizedQueue;
        public Random random;
        // construct an empty randomized queue
        public RandomizedQueueList()
        {
            this.randomizedQueue = new LinkedList<Item>();
            random = new Random();
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            return randomizedQueue.Count == 0;
        }

        // return the number of items on the randomized queue
        public int Size()
        {
            return randomizedQueue.Count;
        }

        // add the item
        public void Enqueue(Item item)
        {
            randomizedQueue.AddLast(item);
        }

        // remove and return a random item
        public Item Dequeue()
        {
            Item deletedNode = Sample();
            randomizedQueue.Remove(deletedNode);
            return deletedNode;
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            int index = random.Next(0, randomizedQueue.Count);
            LinkedListNode<Item> node = randomizedQueue.First;

            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            return node.Value;;
        }

        // return an independent iterator over items in random order
        public IEnumerator<Item> Iterator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return randomizedQueue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}