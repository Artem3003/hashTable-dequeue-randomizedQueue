using System;

namespace HashTableDequeRandomizedQueue
{
    class DequeList<Item> : IIterator<Item> {
        private LinkedList<Item> deque;
        private LinkedListNode<Item> currentNode;
        public bool HasNext => currentNode != null;

        // construct an empty deque
        public DequeList()
        {
            this.deque = new LinkedList<Item>();
        }

        // is the deque empty?
        public bool IsEmpty()
        {
            return deque.Count == 0;
        }

        // return the number of items on the deque
        public int Size()
        {
            return deque.Count;
        }

        // add the item to the front
        public void AddFirst(Item item)
        {
            deque.AddFirst(item);
        }

        // add the item to the back
        public void AddLast(Item item)
        {
            deque.AddLast(item);
        }

        // remove and return the item from the front
        public Item RemoveFirst()
        {
            Item removed = deque.First.Value;
            deque.RemoveFirst();
            return removed;
        }

        // remove and return the item from the back
        public Item RemoveLast()
        {
            Item removed = deque.Last.Value;
            deque.RemoveLast();
            return removed;
        }

        // return an iterator over items in order from front to back
        public IEnumerator<Item> Iterator()
        {
            return deque.GetEnumerator();
        }

        public Item MoveNext()
        {
            LinkedListNode<Item> node = currentNode;
            if (HasNext)
            {
                currentNode = currentNode.Next;
            }
            return node.Value;
        }
    }
}