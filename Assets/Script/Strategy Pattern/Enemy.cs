using UnityEngine;

namespace Script.Strategy_Pattern
{
    /// <summary>
    /// Strategy 
    /// </summary>
    public abstract class Enemy
    {
        public abstract void Fight();
        public abstract void Ride();
    }
}
