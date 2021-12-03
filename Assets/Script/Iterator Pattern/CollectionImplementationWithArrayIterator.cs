using UnityEngine;

namespace Script.Iterator_Pattern
{
    /// <summary>
    /// Concrete implementation with  array Iterator .
    /// </summary>
    public class CollectionImplementationWithArrayIterator : IIterator
    {
        /// <summary>
        /// Array in which value will be stored .
        /// </summary>
        private readonly int[] _storedArray;
        /// <summary>
        /// Index track .
        /// </summary>
        private int _indexTrack = 0;
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="arrayThatWillBeStored"></param>
        public CollectionImplementationWithArrayIterator(int[] arrayThatWillBeStored)
        {
            _storedArray = arrayThatWillBeStored;
        }
        /// <summary>
        /// Get the next item .
        /// </summary>
        /// <returns></returns>
        public object Next()
        {
            var result = _storedArray[_indexTrack];
            ++_indexTrack;
            return result;
        }
        /// <summary>
        /// Has next .
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return (_indexTrack < _storedArray.Length);
        }
    }
}
