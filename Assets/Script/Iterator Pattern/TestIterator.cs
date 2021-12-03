using System.Collections.Generic;
using UnityEngine;

namespace Script.Iterator_Pattern
{
    /// <summary>
    /// Test iterator .
    /// </summary>
    public class TestIterator : MonoBehaviour
    {
        /// <summary>
        /// Start the instance .
        /// </summary>
        private void Start()
        {
            var arrayCreated = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            var collection = new CollectionImplementationWithArray(arrayCreated);
            var arrayIterator = collection.GetIterator();
            while (arrayIterator.HasNext())
            {
                var result = (int) arrayIterator.Next();
                Debug.Log("--->"+result);
            }
            var listCreated = new List<int>(){10,20,30,40,50,60,70,80,90};
            var collectionWithList = new CollectionImplementationWithList(listCreated);
            var listIterator = collectionWithList.GetIterator();
            while (listIterator.HasNext())
            {
                 var result = (int) listIterator.Next();
                 Debug.Log("--->"+result);
            }
        }
    }
}
