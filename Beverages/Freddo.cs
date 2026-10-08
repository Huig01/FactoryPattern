namespace FactoryPattern.Beverages
{
    internal class Freddo : Beverage
    {
        public Freddo()
        {
            name = "Freddo";
            baseIngredient = "Espresso";
            condiments.Add("Liqour");
            condiments.Add("Ice");
            cost = 3.10;
        }
    }
}