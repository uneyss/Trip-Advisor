using System;

namespace IteratorPattern.Classes
{
    interface AbstractIterator
    {
        Hotels First();
        Hotels Next();
        bool IsCompleted { get; }
    }
}
