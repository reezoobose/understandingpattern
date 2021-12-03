using UnityEngine;

namespace Script.Decorator_Pattern
{
    public class GoldenGuard : Weapon
    {
        private readonly Weapon _primaryWeapon;
        public GoldenGuard(Weapon primaryWeapon)
        {
            _primaryWeapon = primaryWeapon;
        }

        public override string WeaponDescription()
        {
            return _primaryWeapon.WeaponDescription() + " Golden Guard Added .";
        }

        public override float WeaponFatalPower()
        {
            return _primaryWeapon.WeaponFatalPower() + (_primaryWeapon.WeaponFatalPower() * 2) / 100;
        }
    }
}
