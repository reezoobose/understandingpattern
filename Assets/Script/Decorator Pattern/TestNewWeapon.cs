using UnityEngine;

namespace Script.Decorator_Pattern
{
    public class TestNewWeapon : MonoBehaviour{
        /// <summary>
        /// Start the instance .
        /// </summary>
        public void Start()
        {
            Debug.Log("First Weapon ...");
            Weapon sword = new Sword();
            Debug.Log(" Sword = "+sword.WeaponDescription()+" Fatality = "+sword.WeaponFatalPower());
            Debug.Log(" Updating ..with silver blade..");
            sword = new SilverBlade(sword);
            Debug.Log(" Sword = "+sword.WeaponDescription()+" Fatality = "+sword.WeaponFatalPower());
            Debug.Log(" Updating ..with silver guard..");
            sword = new SilverGuard(sword);
            Debug.Log("Final Sword = "+sword.WeaponDescription()+" Fatality = "+sword.WeaponFatalPower());
            Debug.Log("\nSecond Weapon ...");
            Weapon swordTwo = new Sword();
            Debug.Log(" Sword = "+swordTwo.WeaponDescription()+" Fatality = "+swordTwo.WeaponFatalPower());
            Debug.Log(" Updating ..with Magic blade..");
            swordTwo = new MagicBlade(swordTwo);
            Debug.Log(" Sword = "+swordTwo.WeaponDescription()+" Fatality = "+swordTwo.WeaponFatalPower());
            Debug.Log(" Updating ..with goldn guard..");
            swordTwo = new GoldenGuard(swordTwo);
            Debug.Log("Final Sword = "+swordTwo.WeaponDescription()+" Fatality = "+swordTwo.WeaponFatalPower());
            
        }
    }
}
