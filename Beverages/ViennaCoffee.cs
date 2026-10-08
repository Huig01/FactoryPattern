namespace FactoryPattern.Beverages
{
    internal class ViennaCoffee : Beverage
    {
        public ViennaCoffee()
        {
            name = "Vienna coffee";
            baseIngredient = "Espresso";
            condiments.Add("Espresso");
            condiments.Add("Whip");
            condiments.Add("Whip");
            cost = 3.10;
        }
    }
}