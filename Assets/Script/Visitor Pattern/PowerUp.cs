using UnityEngine;

namespace Script.Visitor_Pattern
{
    [CreateAssetMenu(fileName = "PowerUpForBike",menuName = "Create PowerUp" , order=1)]
    public class PowerUp : ScriptableObject , IVisitor
    {
        public int shieldPowerIncrementer;
        public int enginePowerIncrementer;
        public int weaponPowerIncrementer;
        
        void IVisitor.Visit(BikeShield bikeShield)
        {
            bikeShield.CurrentShieldValue += shieldPowerIncrementer;
        }

        void IVisitor.Visit(BikeWeapon bikeWeapon)
        {
            bikeWeapon.CurrentWeaponValue += weaponPowerIncrementer;
        }

        void IVisitor.Visit(BikeEngine bikeEngine)
        {
            bikeEngine.CurrentEngineValue += enginePowerIncrementer;
        }
    }
}