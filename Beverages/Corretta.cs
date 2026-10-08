namespace FactoryPattern.Beverages
{
    internal class Corretta : Beverage
    {
        public Corretta()
        {
            name = "Corretta";
            baseIngredient = "Espresso";
            condiments.Add("Liqour");
            cost = 3.00;
        }
    }
}