using System;
using NUnit.Framework;

namespace HashTableDequeRandomizedQueue
{
    class UnitTests
    {
        // Unit tests deque
        public void TestDequeIsEmpty()
        {

            // list
            DequeList<int> deque = new DequeList<int>();
            Assert.IsTrue(deque.IsEmpty(), "Error: TestDequeIsEmpty");
            deque.AddFirst(100);
            Assert.IsFalse(deque.IsEmpty(), "Error: TestDequeIsEmpty");

            // array
            DequeArray<int> deque2 = new DequeArray<int>();
            Assert.IsTrue(deque2.IsEmpty(), "Error: TestDequeIsEmpty");
            deque2.AddFirst(100);
            Assert.IsFalse(deque2.IsEmpty(), "Error: TestDequeIsEmpty");
        }

        public void TestDequeSize()
        {
            // list
            DequeList<int> deque = new DequeList<int>();
            Assert.Equals(0, deque.Size());
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddFirst(3);
            deque.RemoveLast();
            Assert.AreEqual(2, deque.Size(), "Error: TestDequeSize");

            // array 
            DequeArray<int> deque2 = new DequeArray<int>();
            Assert.AreEqual(0, deque2.Size(), "Error: TestDequeSize");
            deque2.AddFirst(1);
            deque2.AddFirst(2);
            deque2.AddFirst(3);
            deque2.RemoveLast();
            Assert.AreEqual(2, deque2.Size(), "Error: TestDequeSize");
        }

        public void TestDequeAddFirst()
        {
            // list
            DequeList<int> deque = new DequeList<int>();
            deque.AddFirst(0);
            deque.AddFirst(100);
            Assert.AreEqual(100, deque.RemoveFirst(), "Error: TestDequeAddFirst");

            // array
            DequeArray<int> deque2 = new DequeArray<int>();
            deque2.AddFirst(0);
            deque2.AddFirst(100);
            Assert.AreEqual(100, deque2.RemoveFirst(), "Error: TestDequeAddFirst");
        }

        public void TestDequeAddLast()
        {
            // list
            DequeList<int> deque = new DequeList<int>();
            deque.AddLast(1);
            deque.AddLast(2);
            Assert.AreEqual(2, deque.RemoveLast(), "Error: TestDequeAddLast");

            // array
            DequeArray<int> deque2 = new DequeArray<int>();
            deque2.AddLast(1);
            deque2.AddLast(2);
            Assert.AreEqual(2, deque2.RemoveLast(), "Error: TestDequeAddLast");
        }

        public void TestDequeRemoveFirst()
        {
            // list 
            DequeList<int> deque = new DequeList<int>();
            deque.AddFirst(1);
            deque.AddLast(2);
            Assert.AreEqual(1, deque.RemoveFirst(), "Error: TestDequeRemoveFirst");
            Assert.AreEqual(2, deque.RemoveFirst(), "Error: TestDequeRemoveFirst");

            // array
            DequeArray<int> deque2 = new DequeArray<int>();
            deque2.AddFirst(1);
            deque2.AddLast(2);
            Assert.AreEqual(1, deque2.RemoveFirst(), "Error: TestDequeRemoveFirst");
            Assert.AreEqual(2, deque2.RemoveFirst(), "Error: TestDequeRemoveFirst");
        }

        public void TestDequeRemoveLast()
        {
            // list
            DequeList<int> deque = new DequeList<int>();
            deque.AddFirst(1);
            deque.AddLast(2);
            Assert.AreEqual(2, deque.RemoveLast(), "Error: TestDequeRemoveLast");
            Assert.AreEqual(1, deque.RemoveLast(), "Error: TestDequeRemoveLast");

            // array
            DequeArray<int> deque2 = new DequeArray<int>();
            deque2.AddFirst(1);
            deque2.AddLast(2);
            Assert.AreEqual(2, deque2.RemoveLast(), "Error: TestDequeRemoveLast");
            Assert.AreEqual(1, deque2.RemoveLast(), "Error: TestDequeRemoveLast");
        }

        public void TestDequeIterator()
        {
            // list
            DequeList<int> deque = new DequeList<int>();
            deque.AddFirst(1);
            deque.AddLast(2);
            IEnumerator<int> iterator = deque.Iterator();
            Assert.AreEqual(1, iterator.Current, "Error: TestDequeIterator");
            Assert.IsTrue(deque.HasNext, "Error: TestDequeIterator");
            iterator.MoveNext();
            Assert.AreEqual(2, iterator.Current, "Error: TestDequeIterator");
            iterator.MoveNext();
            Assert.IsFalse(deque.HasNext, "Error: TestDequeIterator");

            // array 
            DequeArray<int> deque2 = new DequeArray<int>();
            deque2.AddFirst(1);
            deque2.AddLast(2);
            IEnumerator<int> iterator2 = deque.Iterator();
            Assert.AreEqual(1, iterator2.Current, "Error: TestDequeIterator");
            Assert.IsTrue(deque2.HasNext, "Error: TestDequeIterator");
            iterator2.MoveNext();
            Assert.AreEqual(2, iterator2.Current, "Error: TestDequeIterator");
            iterator2.MoveNext();
            Assert.IsFalse(deque2.HasNext, "Error: TestDequeIterator");
        }

        // Unit tests randomized queue
        public void TestRandomizedQueueIsEmpty()
        {
            bool isCorrect = true;

            // list
            RandomizedQueueList<int> queue = new RandomizedQueueList<int>();
            Assert.IsTrue(queue.IsEmpty(), "Error: TestRandomizedQueueIsEmpty");
            queue.Enqueue(100);
            Assert.IsFalse(queue.IsEmpty(), "Error: TestRandomizedQueueIsEmpty");

            // array
            RandomizedQueueArray<int> queue2 = new RandomizedQueueArray<int>();
            Assert.IsTrue(queue2.IsEmpty(), "Error: TestRandomizedQueueIsEmpty");
            queue2.Enqueue(100);
            Assert.IsFalse(queue2.IsEmpty(), "Error: TestRandomizedQueueIsEmpty");

            Assert.IsTrue(isCorrect, "Error: TestRandomizedQueueIsEmpty");
        }

        public void TestRandomizedQueueSize()
        {
            // list
            RandomizedQueueList<int> queue = new RandomizedQueueList<int>();
            Assert.AreEqual(0, queue.Size(), "Error: TestRandomizedQueueSize");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Assert.AreEqual(2, queue.Size(), "Error: TestRandomizedQueueSize");

            // array 
            RandomizedQueueArray<int> queue2 = new RandomizedQueueArray<int>();
            Assert.AreEqual(0, queue2.Size(), "Error: TestRandomizedQueueSize");
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            queue2.Dequeue();
            Assert.AreEqual(2, queue2.Size(), "Error: TestRandomizedQueueSize");
        }
        
        public void TestRandomizedQueueEnqueue()
        {
            int item = 100;

            // list
            RandomizedQueueList<int> queue = new RandomizedQueueList<int>();
            queue.Enqueue(item);
            Assert.AreEqual(1, queue.Size(), "Error: TestRandomizedQueueEnqueue");
            Assert.AreEqual(item, queue.Sample(), "Error: TestRandomizedQueueEnqueue");

            // array
            RandomizedQueueList<int> queue2 = new RandomizedQueueList<int>();
            queue2.Enqueue(item);
            Assert.AreEqual(1, queue2.Size(), "Error: TestRandomizedQueueEnqueue");
            Assert.AreEqual(item, queue2.Sample(), "Error: TestRandomizedQueueEnqueue");
        }

        public void TestRandomizedQueueDequeue()
        {
            // list 
            RandomizedQueueList<int> queue = new RandomizedQueueList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Assert.AreNotEqual(queue.Dequeue(), queue.Dequeue(), "Error: TestRandomizedQueueDequeue");
            Assert.AreEqual(4, queue.Size(), "Error: TestRandomizedQueueDequeue");

            // array
            RandomizedQueueList<int> queue2 = new RandomizedQueueList<int>();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            queue2.Enqueue(4);
            queue2.Enqueue(5);
            queue2.Enqueue(6);
            Assert.AreNotEqual(queue2.Dequeue(), queue2.Dequeue(), "Error: TestRandomizedQueueDequeue");
            Assert.AreEqual(4, queue2.Size(), "Error: TestRandomizedQueueDequeue");
        }

        public void TestRandomizedQueueSample()
        {
            // list
            RandomizedQueueList<int> queue = new RandomizedQueueList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Assert.AreNotEqual(queue.Sample(), queue.Sample(), "Error: TestRandomizedQueueSample");
            Assert.AreNotEqual(queue.Sample(), queue.Sample(), "Error: TestRandomizedQueueSample");
            Assert.AreEqual(6, queue.Size(), "Error: TestRandomizedQueueSample");

            // array
            RandomizedQueueArray<int> queue2 = new RandomizedQueueArray<int>();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            queue2.Enqueue(4);
            queue2.Enqueue(5);
            queue2.Enqueue(6);
            Assert.AreNotEqual(queue2.Sample(), queue2.Sample(), "Error: TestRandomizedQueueSample");
            Assert.AreNotEqual(queue2.Sample(), queue2.Sample(), "Error: TestRandomizedQueueSample");
            Assert.AreEqual(6, queue.Size(), "Error: TestRandomizedQueueSample");
        }
        
        public void TestRandomizedQueueIterator()
        {
            // list
            RandomizedQueueList<int> queue = new RandomizedQueueList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            List<int> expected = new List<int>() {1, 2};
            List<int> actual = new List<int>();
            IEnumerator<int> iterator = queue.Iterator();
            while(iterator.MoveNext())
            {
                actual.Add(iterator.Current);
            }
            Assert.AreEqual(expected.Count, actual.Count, "Error: TestRandomizedQueueIterator");

            // array
            RandomizedQueueArray<int> queue2 = new RandomizedQueueArray<int>();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            List<int> expected2 = new List<int>() {1, 2};
            List<int> actual2 = new List<int>();
            IEnumerator<int> iterator2 = queue2.Iterator();
            while(iterator2.MoveNext())
            {
                actual2.Add(iterator2.Current);
            }
            Assert.AreEqual(expected2.Count, actual2.Count, "Error: TestRandomizedQueueIterator");
        }
    }
}