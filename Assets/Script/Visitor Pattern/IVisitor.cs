using UnityEngine;

namespace Script.Visitor_Pattern
{
    public interface IVisitor 
    {
        void Visit(BikeShield bikeShield);
        void Visit(BikeEngine bikeEngine);
        void Visit(BikeWeapon bikeWeapon);
    }
}
