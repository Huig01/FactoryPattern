namespace FactoryPattern.Beverages
{
    internal class Macchiato : Beverage
    {
        public Macchiato()
        {
            name = "Macchiato";
            baseIngredient = "Espresso";
            condiments.Add("Milk Foam");
            cost = 2.20;
        }
    }
}