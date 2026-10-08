namespace FactoryPattern.Beverages
{
    internal class LatteMacchiato : Beverage
    {
        public LatteMacchiato()
        {
            name = "Latte macchiato";
            baseIngredient = "Espresso";
            condiments.Add("Steamed Milk");
            condiments.Add("Steamed Milk");
            condiments.Add("Milk Foam");
            cost = 2.90;
        }
    }
}