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
            size = sizeOfHashTable;
            counter = 0;
            keys = new KItem[size];
            values = new VItem[size];
        }

        public HashTable(int intialCapacity) 
        {
            size = intialCapacity;
            counter = 0;
            keys = new KItem[size];
            values = new VItem[size];
        }

        public void Add(KItem key, VItem value)
        {
            if (counter >= (size / 2))
            {
                Rehash(Convert.ToInt32(Math.Round(size * 2.5)));
            }

            int attempts = 0;
            int index = GetHashIndex(key, attempts);

            while (keys[index] != null && !keys[index].Equals(default(KItem)))
            {
                attempts++;
                index = GetHashIndex(key, attempts);
            }

            keys[index] = key;
            values[index] = value;
            counter++;
        }

        public void Remove(KItem key)
        {
            int attempts = 0;
            int index = GetHashIndex(key, attempts);

            while (keys[index] != null && !keys[index].Equals(default(KItem)))
            {
                if (keys[index].Equals(key))
                {
                    keys[index] = default(KItem);
                    values[index] = default(VItem);
                    counter--;
                    break;
                }
                attempts++;
                index = GetHashIndex(key, attempts);
            }
        }

        public VItem Get(KItem key)
        {
            int attempts = 0;
            int index = GetHashIndex(key, attempts);

            while (keys[index] != null && !keys[index].Equals(default(KItem)))
            {
                if (keys[index].Equals(key))
                {
                    return values[index];
                }
                attempts++;
                index = GetHashIndex(key, attempts);
            }
            throw new KeyNotFoundException("The given key not found in the HashTable");
        }
        
        public bool Contains(VItem value)
        {
            return values.Contains(value);
        }
        
        public void Clear()
        {
            keys = new KItem[size];
            values = new VItem[size];
            counter = 0;
        }
        
        public int Size()
        {
           return counter;
        }

        private void Rehash(int newSize)
        {
            KItem[] oldKeys = keys;
            VItem[] oldValues = values;
            int oldSize = size;

            size = newSize;
            counter = 0;
            keys = new KItem[size];
            values = new VItem[size];

            for (int i = 0; i < oldSize; i++)
            {
                if (oldKeys[i] != null && !oldKeys[i].Equals(default(KItem)))
                {
                    Add(oldKeys[i], oldValues[i]);
                }
            }
        }

        private int HashFunction(KItem key)
        {
            int hash = key.GetHashCode();
            return Math.Abs(hash) % size;
        }

        private int SecondaryHashFunction(KItem key)
        {
            int hash = key.GetHashCode();
            return (Math.Abs(hash) % primeNumber) + 1;
        }

        private int GetHashIndex(KItem key, int attempts)
        {
            int primaryHash = HashFunction(key);
            int secondaryHash = SecondaryHashFunction(key);
            return (primaryHash + (attempts * secondaryHash)) % size;
        }
    }
}