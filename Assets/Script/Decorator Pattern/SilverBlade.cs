using UnityEngine;

namespace Script.Decorator_Pattern
{
    public class SilverBlade : WeaponDecorator
    {
        private readonly Weapon _primaryWeapon;
        public SilverBlade(Weapon primaryWeapon)
        {
            _primaryWeapon = primaryWeapon;
        }

        public override string WeaponDescription()
        {
            return _primaryWeapon.WeaponDescription() + " Silver blade Added .";
        }

        public override float WeaponFatalPower()
        {
            return _primaryWeapon.WeaponFatalPower() + (_primaryWeapon.WeaponFatalPower() * 10) / 100;
        }
    }
}
