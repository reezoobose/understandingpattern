namespace Script.Command_Pattern.ExampleOne
{
    public class CommandConcrete : ICommand
    {
        /// <summary>
        /// Receiver .
        /// </summary>
        private readonly Receiver _receiver;
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="receiver"></param>
        public CommandConcrete(Receiver receiver)
        {
            _receiver = receiver;
        }
        /// <summary>
        /// Execute .
        /// </summary>
        public void Execute()
        {
            _receiver.ReceiverAction();
        }
    }
}
