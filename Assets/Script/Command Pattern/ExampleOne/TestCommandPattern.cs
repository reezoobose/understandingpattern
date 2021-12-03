using UnityEngine;

namespace Script.Command_Pattern.ExampleOne
{
    public class TestCommandPattern : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            var receiverWhoWillReceiveTheCommand = new ConcreteReceiver();
            var commandThatIWantToExecute = new CommandConcrete(receiverWhoWillReceiveTheCommand);
            var invoker = new Invoker(commandThatIWantToExecute);
            invoker.ExecuteCommand();
        }
    }
}
