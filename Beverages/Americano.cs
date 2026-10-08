namespace FactoryPattern.Beverages
{
    internal class Americano : Beverage
    {
        public Americano()
        {
            name = "Americano";
            baseIngredient = "Espresso";
            condiments.Add("Water");
            condiments.Add("Water");
            cost = 2.20;
        }
    }
}