using System;
using UnityEngine;

namespace Script.SingleTone
{
    public class Manager : SingleToneUnity<Manager>
    {
        public int currentValue = 100;
    }
}
