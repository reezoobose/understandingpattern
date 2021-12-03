using UnityEngine;

namespace Script.Command_Pattern.ExampleTwo
{
    /// <summary>
    ///     Macro that can execute multiple commands .
    /// </summary>
    public class Macro : ICommand
    {
        /// <summary>
        /// List of commands .
        /// </summary>
        private readonly ICommand[] _commands;
        
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="commands"></param>
        public Macro(params ICommand[] commands)
        {
            _commands = new ICommand[commands.Length];
            for (var i = 0; i < _commands.Length; i++) _commands[i] = commands[i];
        }
        
        /// <summary>
        /// Execute .
        /// </summary>
        public void Execute()
        {
            Debug.Log("Executing a Macro");
            foreach (var command in _commands) command.Execute();
        }
    }
}