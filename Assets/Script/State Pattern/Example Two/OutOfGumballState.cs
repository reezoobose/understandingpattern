using UnityEngine;

namespace FSMImplementation
{
    public class OutOfGumballState : State
    {
        private GumballMachine _machine;
        
        public OutOfGumballState(GumballMachine machineInstance)
        {
            _machine = machineInstance;
        }
        
        public override void InsertQuarter()
        {
            Debug.Log("This is no allowed at this point . We are sorry there is no Reward left .");
        }
        
        public override void EjectQuarter()
        {
            Debug.Log("You have not entered any coin .");
        }

        public override void TurnCrank()
        {
            Debug.Log("You have not entered any coin .");
        }
        
        
        public override void Dispose()
        {
            Debug.Log("This is not allowed at this point . ");
        }
    }
}


