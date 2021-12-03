using UnityEngine;

namespace Script.Visitor_Pattern
{
    public class BikeEngine :MonoBehaviour, IBikeElement
    {
        public int CurrentEngineValue;
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
