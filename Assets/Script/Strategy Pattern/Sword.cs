using UnityEngine;

namespace Script.Strategy_Pattern
{
    /// <summary>
    /// Sword .
    /// </summary>
    public class Sword : IWeapon
    {
        public void ChoseWeapon()
        {
            Debug.Log("Choose to fight with Sword .");
        }
    }
}
