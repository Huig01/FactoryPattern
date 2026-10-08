namespace FactoryPattern.Beverages
{
    internal class MeadRaf : Beverage
    {
        public MeadRaf()
        {
            name = "Mead raf";
            baseIngredient = "Espresso";
            condiments.Add("Honey");
            condiments.Add("Cream");
            cost = 2.90;
        }
    }
}