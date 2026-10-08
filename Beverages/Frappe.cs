namespace FactoryPattern.Beverages
{
    internal class Frappe : Beverage
    {
        public Frappe()
        {
            name = "Frappe";
            baseIngredient = "Espresso";
            condiments.Add("Steamed Milk");
            condiments.Add("Steamed Milk");
            condiments.Add("Ice cream");
            cost = 3.40;
        }
    }
}