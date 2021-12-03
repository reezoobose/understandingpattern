using UnityEngine;

namespace Script.Strategy_Pattern
{
    public class HunterEnemy : Enemy
    {
        private readonly IWeapon _weapon;
        private readonly IMove _move;
        /// <summary>
        /// Constructor .
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="move"></param>
        public HunterEnemy(IWeapon weapon , IMove move)
        {
            Debug.Log("Hunter Enemy created .");
            _move = move;
            _weapon = weapon;
        }
        public override void Fight()
        {
            _weapon.ChoseWeapon();
        }

        public override void Ride()
        {
            _move.Move();
        }
    }
}
