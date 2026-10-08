namespace FactoryPattern.Beverages
{
    internal class Frappuccino : Beverage
    {
        public Frappuccino()
        {
            name = "Frappuccino";
            baseIngredient = "Espresso";
            condiments.Add("Ice");
            condiments.Add("Steamed Milk");
            condiments.Add("Whip");
            cost = 3.30;
        }
    }
}