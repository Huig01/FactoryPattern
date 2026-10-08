namespace FactoryPattern.Beverages
{
    internal class IrishCoffee : Beverage
    {
        public IrishCoffee()
        {
            name = "Irish Coffee";
            baseIngredient = "Espresso";
            condiments.Add("Espresso");
            condiments.Add("Whiskey");
            condiments.Add("Whip");
            cost = 3.50;
        }
    }
}