namespace FactoryPattern.Beverages
{
    internal class Breve : Beverage
    {
        public Breve()
        {
            name = "Breve";
            baseIngredient = "Espresso";
            condiments.Add("Milk Foam");
            condiments.Add("Half Milk");
            cost = 2.70;
        }
    }
}