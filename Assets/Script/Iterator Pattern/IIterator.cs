using UnityEngine;

namespace Script.Iterator_Pattern
{
    public interface IIterator
    {
        object Next();
        bool HasNext();
    }
}
