using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Factor
{
    public class PrimeFactor : MonoBehaviour
    {
        /// <summary>
        /// Start the instance .
        /// </summary>
        private void Start()
        {
            var factors = GetFactor(2000000004);
            var factorString = string.Join(",",factors);
            Debug.Log(factorString);
        }
        
        /// <summary>
        /// Get factor .
        /// </summary>
        /// <param name="numberWantToFactor"></param>
        /// <returns></returns>
        private static IEnumerable<int> GetFactor(int numberWantToFactor)
        {
            var list = new List<int>();
            const int startFactor = 2;
            var current = numberWantToFactor;
            while (current % startFactor == 0)
            {
                current /= startFactor;
                list.Add(startFactor);
            }
            const int nextFactor = startFactor + 1;
            for (var  i = nextFactor;  Math.Sqrt(current)>=i ; i += 2)
            {
                while (current % i == 0)
                {
                     current /= i;
                     list.Add(i);
                }
            }

            if (current > 1) list.Add(current);
            return list;
        }
    }
}
