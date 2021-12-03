using UnityEngine;

namespace Script.Strategy_Pattern
{
    public class MoveByHorse : IMove
    {
        public void Move()
        {
            Debug.Log("Moving on a horse.");
        }
    }
}
