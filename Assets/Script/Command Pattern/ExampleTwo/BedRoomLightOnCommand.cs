namespace Script.Command_Pattern.ExampleTwo
{
    /// <summary>
    /// Bed room light command .
    /// </summary>
    public class BedRoomLightOnCommand : ICommand
    {
        /// <summary>
        /// Light .
        /// </summary>
        private readonly Light _light;
        
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="bedroomLight"></param>
         public BedRoomLightOnCommand(Light bedroomLight)
         {
             _light = bedroomLight;
         }
        /// <summary>
        /// Execute .
        /// </summary>
        public void Execute()
        {
            _light.LightOn();
        }
    }
}
