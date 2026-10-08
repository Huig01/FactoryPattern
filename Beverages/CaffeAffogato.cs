namespace FactoryPattern.Beverages
{
    internal class CaffeAffogato : Beverage
    {
        public CaffeAffogato()
        {
            name = "Caffé affogato";
            baseIngredient = "Espresso";
            condiments.Add("Espresso");
            condiments.Add("Ice cream");
            cost = 3.20;
        }
    }
}