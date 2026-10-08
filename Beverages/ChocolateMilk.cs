namespace FactoryPattern.Beverages
{

    internal class ChocolateMilk : Beverage
    {
        public ChocolateMilk()
        {
            name = "Chocolate milk";
            baseIngredient = "Chocolate";
            condiments.Add("Milk");
            condiments.Add("Milk");
            cost = 2.40;
        }
    }
}