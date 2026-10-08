namespace FactoryPattern.Beverages
{
    internal class Galao : Beverage
    {
        public Galao()
        {
            name = "Galao";
            baseIngredient = "Espresso";
            condiments.Add("Milk Foam");
            condiments.Add("Milk Foam");
            cost = 2.60;
        }
    }
}