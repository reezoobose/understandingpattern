using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Script.Command_Pattern.ExampleTwo
{
    public class TestLight : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            var bedroomLight = new BedRoomLight();
            var lightOnCommandMap = new BedRoomLightOnCommand(bedroomLight);
            var lightOffCommandMap = new BedRoomLightOffCommand(bedroomLight);
            var micro = new Macro(lightOnCommandMap,lightOffCommandMap);
            var remote = new Remote(lightOnCommandMap, lightOffCommandMap,micro);
            remote.LightOn();
            remote.LightOff();
            remote.Party();
        }
    }
}
