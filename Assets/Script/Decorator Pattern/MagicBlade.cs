using UnityEngine;

namespace Script.Decorator_Pattern
{
    public class MagicBlade : Weapon
    {
        private readonly Weapon _primaryWeapon;
        public MagicBlade(Weapon primaryWeapon)
        {
            _primaryWeapon = primaryWeapon;
        }

        public override string WeaponDescription()
        {
            return _primaryWeapon.WeaponDescription() + " Magic blade Added .";
        }

        public override float WeaponFatalPower()
        {
            return _primaryWeapon.WeaponFatalPower() + (_primaryWeapon.WeaponFatalPower() * 70) / 100;
        }
    }
}
