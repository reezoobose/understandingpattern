namespace Script.Command_Pattern.ExampleTwo
{
    /// <summary>
    /// Bed room light off command .
    /// </summary>
    public class BedRoomLightOffCommand : ICommand
    {
        /// <summary>
        /// Light .
        /// </summary>
        private readonly Light _light;
        
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="bedroomLight"></param>
        public BedRoomLightOffCommand(Light bedroomLight)
        {
            _light = bedroomLight;
        }
        /// <summary>
        /// Execute .
        /// </summary>
        public void Execute()
        {
            _light.LightOff();
        }
    }
}
