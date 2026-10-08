namespace FactoryPattern.Beverages
{
    internal class FlatWhite : Beverage
    {
        public FlatWhite()
        {
            name = "Flat White";
            baseIngredient = "Espresso";
            condiments.Add("Steamed Milk");
            condiments.Add("Steamed Milk");
            cost = 2.80;
        }
    }
}