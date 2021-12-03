using System.Collections.Generic;

namespace Script.Iterator_Pattern
{
    public class CollectionImplementationWithList
    {
        /// <summary>
        ///     List received .
        /// </summary>
        private readonly List<int> _listReceived;

        /// <summary>
        ///     Constructor .
        /// </summary>
        /// <param name="listOfInteger"></param>
        public CollectionImplementationWithList(List<int> listOfInteger)
        {
            _listReceived = listOfInteger;
        }

        /// <summary>
        ///     Get the iterator .
        /// </summary>
        /// <returns></returns>
        public IIterator GetIterator()
        {
            return new CollectionImplementationWithListIterator(_listReceived);
        }
    }
}