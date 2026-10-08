namespace FactoryPattern.Beverages
{
    internal class Romana : Beverage
    {
        public Romana()
        {
            name = "Romana";
            baseIngredient = "Espresso";
            condiments.Add("Lemon");
            cost = 2.20;
        }
    }
}