using UnityEngine;

namespace Script.SingleTone
{
    public class SingleTone
    {
        private static readonly SingleTone StoredSingleTone;
        static SingleTone()
        {
            if(StoredSingleTone== null)
                StoredSingleTone =  new SingleTone();
        }

        public static SingleTone Reference => StoredSingleTone;

        public void CallThisTestMethod()
        {
            Debug.Log("This is a test method called .");
        }
    }
}
