namespace FactoryPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            name = "Espresso";
            baseIngredient = "Espresso";
            cost = 1.99;
        }
    }
}