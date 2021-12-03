using System;
using UnityEngine;

namespace Script.SingleTone
{
    public class SingleToneTest : MonoBehaviour
    {
        private void Start()
        {
            SingleTone.Reference.CallThisTestMethod();
        }
    }
}
