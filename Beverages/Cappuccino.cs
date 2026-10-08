namespace FactoryPattern.Beverages
{
    internal class Cappuccino : Beverage
    {
        public Cappuccino()
        {
            name = "Cappuccino";
            baseIngredient = "Espresso";
            condiments.Add("Steamed Milk");
            condiments.Add("Milk Foam");
            cost = 2.60;
        }
    }
}