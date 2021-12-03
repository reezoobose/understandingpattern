using UnityEngine;

namespace Script.Command_Pattern.ExampleOne
{
    /// <summary>
    /// Receiver class .
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Received action .
        /// </summary>
        public virtual void ReceiverAction()
        {
            Debug.Log("Action performed .");
        }
    }
}
