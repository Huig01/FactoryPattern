namespace FactoryPattern.Beverages
{
    internal class CaramelFrappuccino : Beverage
    {
        public CaramelFrappuccino()
        {
            name = "Caramel frappuccino";
            baseIngredient = "Espresso";
            condiments.Add("Ice");
            condiments.Add("Steamed Milk");
            condiments.Add("Cream");
            condiments.Add("Syrup");
            cost = 3.60;
        }
    }
}