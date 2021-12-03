using UnityEngine;

namespace FSMImplementation
{
    public class GumballSoldState : State
    {
        private readonly GumballMachine _machine;
        
        public GumballSoldState(GumballMachine machineInstance)
        {
            _machine = machineInstance;
        }
        
        public override void InsertQuarter()
        {
            Debug.Log("You have already entered the coin . Under processing ...");
        }
        
        public override void EjectQuarter()
        {
            Debug.Log("This is no allowed at this point . Coin processed ....");
        }

        public override void TurnCrank()
        {
            Debug.Log("Crank was already turned . You are not getting again .");
        }
        
        public override void Dispose()
        {
            Debug.Log("Thank you we are giving you the reward !!! ");
            if (_machine.NumberOfBalls > 0) {
                _machine.CurrentState = _machine.NoQuarterStateDerived;
                return;
            }
            _machine.CurrentState = _machine.GumballSoldStateDerived;
            Debug.Log("State changed .");
        }
    }
}

