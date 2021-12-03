using System.Collections.Generic;

namespace Script.Iterator_Pattern
{
    /// <summary>
    ///     Collection implementation with list .
    /// </summary>
    public class CollectionImplementationWithListIterator : IIterator
    {
        /// <summary>
        /// List of integers .
        /// </summary>
        private readonly List<int> _listOfIntegerNumbers;
        /// <summary>
        /// List Index Tracker .
        /// </summary>
        private int _listIndexTracker = 0;
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="listOfIntegerNumbers"></param>
        public CollectionImplementationWithListIterator(List<int> listOfIntegerNumbers)
        {
            _listOfIntegerNumbers = listOfIntegerNumbers;
        }

        /// <summary>
        /// Get the next element .
        /// </summary>
        /// <returns></returns>
        public object Next()
        {
            var item = _listOfIntegerNumbers[_listIndexTracker];
            _listIndexTracker++;
            return item;
        }
        /// <summary>
        /// Has next .
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return _listIndexTracker < _listOfIntegerNumbers.Count;
        }
    }
}