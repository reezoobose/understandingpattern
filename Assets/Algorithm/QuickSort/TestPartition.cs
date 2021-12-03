using System;
using UnityEngine;

namespace Algorithm.QuickSort
{
    public class TestPartition : MonoBehaviour
    {
        public void Start()
        {
            var partitionTest = new QuickSort();
            //partitionTest.Sort(5, 0, 9, 4, 10, 8, 2, 1, 7, 3, 6);
            partitionTest.ThreeWaySort( 80, 65, 66, 88, 87, 80, 80, 86, 80, 68, 80, 67, 89, 90);
        }
    }
}