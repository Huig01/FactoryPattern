namespace FactoryPattern.Beverages
{
    internal class DemiCreme : Beverage
    {
        public DemiCreme()
        {
            name = "Demi-crème";
            baseIngredient = "Espresso";
            condiments.Add("Espresso");
            condiments.Add("Cream");
            condiments.Add("Cream");
            cost = 3.00;
        }
    }
}