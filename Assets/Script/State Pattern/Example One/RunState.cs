using UnityEngine;

namespace Script.State_Pattern
{
    public class RunState : IState
    {
        private readonly StateMachine _machine;
        private IState _stateImplementation;

        public RunState(StateMachine stateMachine)
        {
            _machine = stateMachine;
        }

        public void Run()
        {
           Debug.Log("You are already running .");
        }

        public void Fly()
        {
            Debug.Log("Current State changed from Running to Flying .");
            _machine.SetState(_machine.GetFlyState);
        }

       
    }
}
