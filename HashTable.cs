using System;

namespace HashTableDequeRandomizedQueue
{
    public class HashTable<KItem, VItem>
    {
        const int sizeOfHashTable = 10;
        const int primeNumber = sizeOfHashTable - 1;
        private KItem[] keys;
        private VItem[]  values;
        private int size;
        private int counter;

        public HashTable() 
        {
        }

        public HashTable(int intialCapacity) 
        {
        }

        public void Add(KItem key, VItem value)
        {
            throw new ArgumentException();
        }

        public void Remove(KItem key)
        {
            throw new ArgumentException();
        }

        public VItem Get(KItem key)
        {
            throw new ArgumentException();
        }
        
        public bool Contains(VItem value)
        {
            throw new ArgumentException();
        }
        
        public void Clear()
        {
            throw new ArgumentException();
        }
        
        public int Size()
        {
            throw new ArgumentException();
        }

        private void Rehash(int newSize)
        {
            throw new ArgumentException();
        }

        private int HashFunction(KItem key)
        {
            throw new ArgumentException();
        }

        private int SecondaryHashFunction(KItem key)
        {
            throw new ArgumentException();
        }

        private int GetHashIndex(KItem key, int attempts)
        {
            throw new ArgumentException();
        }
    }
}