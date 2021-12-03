using UnityEngine;

namespace Algorithm.QuickSort
{
    public class QuickSort
    {
        
        /// <summary>
        /// Sort .
        /// </summary>
        /// <param name="array"></param>
        public void Sort(params int[] array)
        {
            // TODO: implement random shuffle
            Sort(array.Length-1 ,0 , array);
            Debug.Log("final Array " + string.Join(",", array));
            
        }

        
        /// <summary>
        /// Three way sort .
        /// </summary>
        /// <param name="array"></param>
        public void ThreeWaySort(params int[] array)
        {
            ThreeWaySort(array.Length-1 ,0 , array);
            Debug.Log("final Array " + string.Join(",", array));
        }
        /// <summary>
        /// Recursive sort .
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="array"></param>
        private void Sort(int high, int low ,params int[] array)
        {
            if (low >= high) return;
            var partitionPoint = Partition(high, low, array);
            Debug.Log(" Partition point selected array index = "+partitionPoint);
            Debug.Log("First part of the array "+PrintArray(partitionPoint-1 , low , array));
            Debug.Log("Second part of the array "+PrintArray(high,partitionPoint+1,array));
            Sort(partitionPoint-1 , low , array);
            Sort(high,partitionPoint+1,array);
        }



        /// <summary>
        /// Three way sort .
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="array"></param>
        private void ThreeWaySort(int high, int low ,params int[] array)
        {
            if (low >= high) return;
            var partitionPoint = ThreeWayPartition(low, high, array);
            var partitionStartPoint = partitionPoint[0];
            var partitionEndPoint = partitionPoint[1];
            Debug.Log("First part of the array "+PrintArray( partitionStartPoint-1, low , array));
            Debug.Log("Second part of the array "+PrintArray(high,partitionEndPoint,array));
            ThreeWaySort(partitionStartPoint-1 , low , array);
            ThreeWaySort(high,partitionEndPoint,array);
        }

        
        /// <summary>
        /// Three way partition .
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int[] ThreeWayPartition(int low, int high,params int[] array)
        {
            var partitionElementPointer = low ;
            var i = low;
            var j = high;
            while (i<=j)
            {
                //When element is smaller than partition element .
                if (array[i] < array[partitionElementPointer])
                {
                    //First we will make a swap .
                    var temp = array[partitionElementPointer];
                    array[partitionElementPointer] = array[i];
                    array[i] = temp;
                    i++;
                    partitionElementPointer++;
                    continue;
                }
                //When element is greater than partition element .
                if (array[i] > array[partitionElementPointer])
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    j--;
                    continue;
                }
                //If the element is same .
                if (array[partitionElementPointer] == array[i])
                {
                    i++;
                }
            }
            Debug.Log("Final After partition = "+ PrintArray(high, low, array));
            return new[] {partitionElementPointer, i};
        }

        /// <summary>
        /// Partition method .
        /// Choose the low element as a partition element .
        /// After partition all the element left to the partition are less and right to partition are bigger .[Invariant]
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="array"></param>
        /// <returns>returns the final partition element position .</returns>
        private int Partition(int high, int low,params int[] array)
        {

            //First pointer that points elements greater than partition element .
            var i = low ;
            //Second pointer that points element less than partition element .
            var j = high + 1;
            Debug.Log("Initial I pointer = "+i+"Initial J pointer = "+j);
            //Loop .
            while (true)
            {
                Debug.Log("  initial Array " + PrintArray(high,low,array));
                while (array[++i] < array[low])
                    if (i == high)
                        break;
                while (array[--j] > array[low])
                    if (j == low)
                        break;
                Debug.Log("  i pointer = "+ i +" pointing to = " + array[i] + " j pointer = "+ j +" pointing to = " + array[j]);
                if (i >= j) break;
                var innerTemp = array[i];
                array[i] = array[j];
                array[j] = innerTemp;
                Debug.Log("  After swapping element" + PrintArray(high,low,array));
            }

            var outerTemp = array[j];
            array[j] = array[low] ;
            array[low] = outerTemp;
            Debug.Log(" After Partitioning an Array " + PrintArray(high,low,array));
            return j;
            
        }
        

        /// <summary>
        /// Print the array .
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        private static string PrintArray(int high, int low, params int[] array)
        {
            var arrayString = " ";
            for (var i = low; i <= high; i++)
                arrayString += array[i] + " ";
            return arrayString;
        }
    }
}
