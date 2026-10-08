namespace FactoryPattern.Beverages
{
    internal class ConPanna : Beverage
    {
        public ConPanna()
        {
            name = "Con Panna";
            baseIngredient = "Espresso";
            condiments.Add("Whip");
            cost = 2.20;
        }
    }
}