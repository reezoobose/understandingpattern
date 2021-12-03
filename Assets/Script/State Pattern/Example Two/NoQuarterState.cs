using UnityEngine;

namespace FSMImplementation
{
    public class NoQuarterState : State
    {
        private GumballMachine _machine;
        
        public NoQuarterState(GumballMachine machineInstance)
        {
            _machine = machineInstance;
        }
        
        public override void InsertQuarter()
        {
            Debug.Log("Quarter inserted");
            _machine.CurrentState = _machine.HasQuarterStateDerived;

        }

        public override void TurnCrank()
        {
            Debug.Log("You have not entered any coin .");
        }

        public override void EjectQuarter()
        {
            Debug.Log("This is no allowed at this point .");
        }

        public override void Dispose()
        {
            Debug.Log("This is not allowed at this point . ");
        }
    }
}
