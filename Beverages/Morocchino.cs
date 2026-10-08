namespace FactoryPattern.Beverages
{
    internal class Morocchino : Beverage
    {
        public Morocchino()
        {
            name = "Morocchino";
            baseIngredient = "Espresso";
            condiments.Add("Chocolate");
            condiments.Add("Milk Foam");
            cost = 2.80;
        }
    }
}