namespace FactoryPattern.Beverages
{
    internal class CaffeLatte : Beverage
    {
        public CaffeLatte()
        {
            name = "Caffé Latte";
            baseIngredient = "Espresso";
            condiments.Add("Steamed Milk");
            condiments.Add("Steamed Milk");
            condiments.Add("Milk Foam"); cost = 2.90;
        }
    }
}