using System;

namespace HashTableDequeRandomizedQueue
{
    interface IIterator<T>
    {
        bool HasNext { get; }
        T MoveNext();
    }
}