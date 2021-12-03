using System;

namespace Script.SingleTone
{
    public class Controller : SingleToneUnity<Controller>
    {
        public void Start()
        {
            Manager.Instance.currentValue = 10;
        }
    }
}
