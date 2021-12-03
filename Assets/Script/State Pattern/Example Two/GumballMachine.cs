using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSMImplementation
{
    public class GumballMachine
    {
        internal  State CurrentState { get; set; }
        internal  HasQuarterState HasQuarterStateDerived { get; }
        internal  GumballSoldState GumballSoldStateDerived { get;}
        internal  NoQuarterState NoQuarterStateDerived { get;}
        internal  OutOfGumballState OutOfGumballStateDerived { get;}
        internal int NumberOfBalls { get; }

        public GumballMachine(int balls )
        {
            HasQuarterStateDerived = new HasQuarterState(this);
            GumballSoldStateDerived = new GumballSoldState(this);
            NoQuarterStateDerived = new NoQuarterState(this);
            OutOfGumballStateDerived = new OutOfGumballState(this);
            NumberOfBalls = balls;
            CurrentState = NoQuarterStateDerived;
        }


        public void InsertACoin()
        {
            CurrentState.InsertQuarter();
        }
        public void TurnCrank()
        {
            CurrentState.TurnCrank();
        }
        public void EjectACoin()
        {
            CurrentState.EjectQuarter();
        }
        public void TakeReward()
        {
            CurrentState.Dispose();
        }
    }
}


