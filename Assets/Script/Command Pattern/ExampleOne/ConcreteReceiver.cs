using UnityEngine;

namespace Script.Command_Pattern.ExampleOne
{
    /// <summary>
    /// Concrete implementation of receiver .
    /// </summary>
    public class ConcreteReceiver : Receiver
    {
        /// <summary>
        /// Receiver Action concrete Implementation .
        /// </summary>
        public override void ReceiverAction()
        {
            base.ReceiverAction();
            Debug.Log("ConcreteReceiver implementation complete .");
        }
    }
}
