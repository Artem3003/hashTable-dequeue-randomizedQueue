using System;
using NUnit.Framework;

namespace HashTableDequeRandomizedQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Deque
            UnitTests tests = new UnitTests();
            tests.TestDequeAddFirst();
            tests.TestDequeAddLast();
            tests.TestDequeIsEmpty();
            tests.TestDequeIterator();
            tests.TestDequeRemoveFirst();
            tests.TestDequeRemoveLast();
            tests.TestDequeSize();

            //Randomized queue
            tests.TestRandomizedQueueDequeue();
            tests.TestRandomizedQueueEnqueue();
            tests.TestRandomizedQueueIsEmpty();
            tests.TestRandomizedQueueIterator();
            tests.TestRandomizedQueueSample();
            tests.TestRandomizedQueueSize();

            // Hash Table
            HashTable<string, bool> dictionary = new HashTable<string, bool>(50);

            using (StreamReader reader = new StreamReader("./numbers.txt"))
            {
                string number;
                while ((number = reader.ReadLine()) != null)
                {
                    dictionary.Add(number, true);
                }
                
            }

           Console.WriteLine(dictionary.Size());
            
            Console.WriteLine(Ispell("Forty-seven", dictionary));
            Console.WriteLine(Ispell("Hundret", dictionary));

            Console.WriteLine("==============");

            AddTest();
            RemoveTest();
            GetTest();
            ContainsTest();
            ClearTest();
            SizeTest();
        }

        // second part of the assignment
        public static bool Ispell(string word, HashTable<string, bool> dictionary)
        {
            try
            {
                if (dictionary.Get(word))
                {
                    Console.WriteLine("OK");
                    return true;
                }
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("WrongSpelling");
                return false;
            }
            return false;
        }

        // unit tests
        public static void AddTest()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>();

            hashTable.Add(1, "apple");
            hashTable.Add(2, "banana");

            string apple = hashTable.Get(1);
            string banana = hashTable.Get(2);

            Assert.AreEqual("apple", apple);
            Assert.AreEqual("banana", banana);
            Console.WriteLine("PASSED: AddTest");
        }   

        public static void RemoveTest()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>();
            
            hashTable.Add(1, "apple");
            hashTable.Add(2, "banana");

            Assert.IsTrue(hashTable.Contains("apple"));

            hashTable.Remove(1); // remove banana

            Assert.IsFalse(hashTable.Contains("apple"));
            Assert.Throws<KeyNotFoundException>(() => hashTable.Get(1));
            Console.WriteLine("PASSED: RemoveTest");
        }

        public static void GetTest()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>();
            
            hashTable.Add(1, "apple");
            hashTable.Add(2, "banana");

            string apple = hashTable.Get(1);
            
            Assert.AreEqual(apple, "apple");
            Console.WriteLine("PASSED: GetTest");
        }

        public static void ContainsTest()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>();
            
            hashTable.Add(1, "apple");
            hashTable.Add(2, "banana");

            Assert.IsTrue(hashTable.Contains("apple"));
            Assert.IsFalse(hashTable.Contains("kivi"));
            Console.WriteLine("PASSED: ContainsTest");
        }

        public static void ClearTest()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>();
            
            hashTable.Add(1, "apple");
            hashTable.Add(2, "banana");

            hashTable.Clear();

            Assert.AreEqual(0, hashTable.Size());
            Console.WriteLine("PASSED: ClearTest");
        }

        public static void SizeTest()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>();
            
            hashTable.Add(1, "apple");
            hashTable.Add(2, "banana");

            Assert.AreEqual(2, hashTable.Size());

            hashTable.Add(5, "banana");

            Assert.AreEqual(3, hashTable.Size());

            Console.WriteLine("PASSED: SizeTest");
        }
    }   
}