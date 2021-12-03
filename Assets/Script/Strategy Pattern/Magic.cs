using UnityEngine;

namespace Script.Strategy_Pattern
{
    public class Magic : IWeapon
    {
        public void ChoseWeapon()
        {
            Debug.Log("Choose to fight with magic .");
        }
    }
}
