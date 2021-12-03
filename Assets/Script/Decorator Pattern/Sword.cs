namespace Script.Decorator_Pattern
{
    /// <summary>
    /// Concrete implementation of Weapon .
    /// </summary>
    public class Sword : Weapon
    {
        public override string WeaponDescription()
        {
            return "A sword is forged .";
        }

        public override float WeaponFatalPower()
        {
            return 40.0f;
        }
    }
}
