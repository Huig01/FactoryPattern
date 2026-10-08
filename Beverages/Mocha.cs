namespace FactoryPattern.Beverages
{
    internal class Mocha : Beverage
    {
        public Mocha()
        {
            name = "Mocha";
            baseIngredient = "Espresso";
            condiments.Add("Chocolate");
            condiments.Add("Steamed Milk");
            condiments.Add("Whip");
            cost = 3.00;
        }
    }
}