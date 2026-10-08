namespace FactoryPattern.Beverages
{
    internal class Glace : Beverage
    {
        public Glace()
        {
            name = "Glace";
            baseIngredient = "Espresso";
            condiments.Add("Ice cream");
            cost = 2.80;
        }
    }
}