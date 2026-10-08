namespace FactoryPattern.Beverages
{
    internal class Doppio : Beverage
    {
        public Doppio()
        {
            name = "Doppio";
            baseIngredient = "Espresso";
            condiments.Add("Espresso");
            cost = 2.50;
        }
    }
}