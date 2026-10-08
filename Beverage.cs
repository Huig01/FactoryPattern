namespace FactoryPattern.Beverages
{
    internal enum Size
    {
        TALL,
        GRANDE,
        VENTI
    }

    internal abstract class Beverage
    {
        public string Name
        {
            get { return name; }
        }

        protected string name = "";
        protected string baseIngredient = "";
        protected List<string> condiments = new List<string>();
        protected double cost;

        public Size Size { get; set; } = Size.TALL;

        internal double Cost()
        {
            if (Size == Size.GRANDE)
                return cost + 0.30;

            if (Size == Size.VENTI)
                return cost + 0.60;

            return cost;
        }

        public override string ToString()
        {
            string result = "Beverage: " + name + "\n";
            result += "Size: " + Size + "\n";
            result += "Base: " + baseIngredient + "\n";

            if (condiments.Count > 0)
            {
                result += "Condiments: ";

                for (int i = 0; i < condiments.Count; i++)
                {
                    result += condiments[i];

                    if (i < condiments.Count - 1)
                        result += ", ";
                }

                result += "\n";
            }

            result += "Price: EUR " + Cost().ToString("0.00"); ;

            return result;
        }
    }
}