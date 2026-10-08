namespace FactoryPattern.Beverages
{ 
    internal class Bicerin : Beverage
    {
        public Bicerin()
        {
            name = "Bicerin";
            baseIngredient = "Espresso";
            condiments.Add("Black Chocolate");
            condiments.Add("White Chocolate");
            condiments.Add("Whip");
            cost = 3.40;
        }
    }
}