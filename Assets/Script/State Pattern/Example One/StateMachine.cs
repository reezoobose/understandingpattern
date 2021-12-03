using TMPro;
using UnityEngine;

namespace Script.State_Pattern
{
    public class StateMachine
    {
        private IState _currentState;
        public FlyState GetFlyState { get; }
        public RunState GetRunState { get; }
        
        /// <summary>
        /// Constructor .
        /// </summary>
        public StateMachine()
        {
            GetFlyState = new FlyState(this);
            GetRunState = new RunState(this);
            //Set default state .
            _currentState = GetRunState;
        }

        public void Run()
        {
            _currentState.Run();
        }

        public void Fly()
        {
            _currentState.Fly();
        }
        /// <summary>
        /// Set state .
        /// </summary>
        /// <param name="state"></param>
        public void SetState(IState state)
        {
            _currentState = state;
        }
    }
}
