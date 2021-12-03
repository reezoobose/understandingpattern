 using UnityEngine;

namespace Script.Command_Pattern.ExampleTwo
{
    /// <summary>
    /// Concrete Receiver .
    /// </summary>
    public class BedRoomLight : Light
    {
        public override void LightOn()
        {
            base.LightOn();
            Debug.Log("Bed Room Light On .");
        }

        public override void LightOff()
        {
            base.LightOff();
            Debug.Log("Bed Room Light Off .");
        }
        
    }
}
