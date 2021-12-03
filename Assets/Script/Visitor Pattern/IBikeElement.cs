namespace Script.Visitor_Pattern
{
    public interface IBikeElement
    {
        void Accept(IVisitor visitor);
    }
}
