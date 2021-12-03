using UnityEngine;

namespace Script.Strategy_Pattern
{
    public class EnemyCreator : MonoBehaviour
    {
        public void Start()
        {
            var moveOnFoot = new MoveByFoot();
            var moveOnHorse = new MoveByHorse();
            var sword = new Sword();
            var magic = new Magic();
            var troop = new FrontLineEnemy(sword, moveOnFoot);
            troop.Fight();
            troop.Ride();
            var witch = new HunterEnemy(magic, moveOnHorse);
            witch.Fight();
            witch.Ride();
        }
    }
}