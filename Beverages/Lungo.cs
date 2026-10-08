namespace FactoryPattern.Beverages
{
    internal class Lungo : Beverage
    {
        public Lungo()
        {
            name = "Lungo";
            baseIngredient = "Espresso";
            condiments.Add("Water");
            cost = 2.10;
        }
    }
}