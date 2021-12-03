using UnityEngine;

namespace Script.Strategy_Pattern
{
    public class MoveByFoot : IMove
    {
        /// <summary>
        /// Move in to foot .
        /// </summary>
        public void Move()
        {
            Debug.Log("Moving on  Foot .");
        }
    }
}
