using UnityEngine;

namespace FSMImplementation
{
    public class HasQuarterState : State
    {
        private readonly GumballMachine _machine;
        
        public HasQuarterState(GumballMachine machineInstance)
        {
            _machine = machineInstance;
        }
        
        public override void InsertQuarter()
        {
            Debug.Log("You have already entered the coin .");
        }

        public override void TurnCrank()
        {
            Debug.Log("Crank was turned .");
            _machine.CurrentState = _machine.GumballSoldStateDerived;
            Debug.Log("State changed .");

        }

        public override void EjectQuarter()
        {
            Debug.Log("This is no allowed at this point . First turn the crank .");
        }

        public override void Dispose()
        {
            Debug.Log("This is not allowed at this point . ");
        }
    }
}

