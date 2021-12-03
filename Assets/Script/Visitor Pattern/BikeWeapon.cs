using UnityEngine;

namespace Script.Visitor_Pattern
{
    public class BikeWeapon :MonoBehaviour, IBikeElement
    {
        public int CurrentWeaponValue;
        
        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
