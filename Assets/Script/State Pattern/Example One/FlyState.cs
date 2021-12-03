using UnityEngine;

namespace Script.State_Pattern
{
    public class FlyState:IState
    {
        private readonly StateMachine _machine;
        public FlyState(StateMachine machine)
        {
            _machine = machine;
        }
        
        public void Run()
        {
            Debug.Log("Current State changed from Flying to run .");
            _machine.SetState(_machine.GetRunState);
        }

        public void Fly()
        {
            Debug.Log("You are already flying .");
        }
    }
}
