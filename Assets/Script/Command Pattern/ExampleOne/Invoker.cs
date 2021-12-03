using UnityEngine;

namespace Script.Command_Pattern.ExampleOne
{
    /// <summary>
    ///     Invoker .
    /// </summary>
    public class Invoker
    {
        /// <summary>
        ///     Command invoker Holder .
        /// </summary>
        private readonly ICommand _commandInvoker;

        /// <summary>
        ///     Constructor .
        /// </summary>
        /// <param name="commandThatWillBeInvoked"></param>
        public Invoker(ICommand commandThatWillBeInvoked)
        {
            _commandInvoker = commandThatWillBeInvoked;
            Debug.Log("Command connected " + nameof(commandThatWillBeInvoked));
        }

        /// <summary>
        ///     Execute Command .
        /// </summary>
        public void ExecuteCommand()
        {
            Debug.Log("Now we will execute the command .");
            _commandInvoker.Execute();
        }
    }
}