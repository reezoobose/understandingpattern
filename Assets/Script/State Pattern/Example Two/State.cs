using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSMImplementation
{
    public abstract class State
    {
        public abstract void InsertQuarter();
        public abstract void TurnCrank();
        public abstract void EjectQuarter();
        public abstract void Dispose();
    }
}
