using UnityEngine;

namespace Script.Visitor_Pattern
{
    public class BikeShield : MonoBehaviour, IBikeElement
    {
        public int CurrentShieldValue;
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
