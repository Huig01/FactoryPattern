namespace FactoryPattern.Beverages
{
    internal class Rafcoffee : Beverage
    {
        public Rafcoffee()
        {
            name = "Raf coffee";
            baseIngredient = "Espresso";
            condiments.Add("Vanilla Sugar");
            condiments.Add("Cream");
            cost = 2.80;
        }
    }
}