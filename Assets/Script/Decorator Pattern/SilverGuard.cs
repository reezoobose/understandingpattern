using UnityEngine;

namespace Script.Decorator_Pattern
{
    public class SilverGuard : Weapon
    {
        private readonly Weapon _primaryWeapon;
        public SilverGuard(Weapon primaryWeapon)
        {
            _primaryWeapon = primaryWeapon;
        }

        public override string WeaponDescription()
        {
            return _primaryWeapon.WeaponDescription() + " Silver Guard Added .";
        }

        public override float WeaponFatalPower()
        {
            return _primaryWeapon.WeaponFatalPower() + (_primaryWeapon.WeaponFatalPower() * 3) / 100;
        }
    }
}
