using UnityEngine;

namespace Script.Command_Pattern.ExampleTwo
{
    /// <summary>
    ///     Receiver .
    /// </summary>
    public class Light
    {
        /// <summary>
        /// Light on .
        /// </summary>
        public virtual void LightOn()
        {
            Debug.Log("Light is On .");
        }
        /// <summary>
        /// Light off .
        /// </summary>
        public virtual void LightOff()
        {
            Debug.Log("Light is off");
        }
    }
}