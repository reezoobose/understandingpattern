using System;

namespace Script.Iterator_Pattern
{
    /// <summary>
    /// Collection implementation .
    /// </summary>
    public class CollectionImplementationWithArray
    {
        /// <summary>
        /// Array in which value will be stored .
        /// </summary>
        private readonly int[] _storedArray;
        
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="arrayThatWillBeStored"></param>
        public CollectionImplementationWithArray(int[] arrayThatWillBeStored)
        {
            _storedArray = arrayThatWillBeStored;
        }
        
        /// <summary>
        /// Get collection .
        /// </summary>
        /// <returns></returns>
        [Obsolete("User iterator ",true)]
        public int[] GetCollection()
        {
            return _storedArray;
        }
        
        /// <summary>
        /// Get Iterator .
        /// </summary>
        /// <returns></returns>
        public IIterator GetIterator()
        {
            return new CollectionImplementationWithArrayIterator(_storedArray);
        }
        

    }
}
