using UnityEngine;

namespace Script.Command_Pattern.ExampleTwo
{
    /// <summary>
    /// Invoker .
    /// </summary>
    public class Remote
    {
        private readonly ICommand _lightOnCommand;
        private readonly ICommand _lightOffCommand;
        private readonly ICommand _commandMacro;

        public Remote(ICommand onCommand , ICommand offCommand , ICommand macro)
        {
            _lightOnCommand = onCommand ;
            _lightOffCommand = offCommand ;
            _commandMacro = macro;
        }


        public void LightOn()
        {
            Debug.Log("Please light on .");
            _lightOnCommand.Execute();
        }

        public void LightOff()
        {
            Debug.Log("Please light off .");
            _lightOffCommand.Execute();
        }

        public void Party()
        {
            Debug.Log("Execute the macro .");
            _commandMacro.Execute();
        }

    }
}
