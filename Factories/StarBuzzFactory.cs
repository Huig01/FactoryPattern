using FactoryPattern.Beverages;

namespace FactoryPattern.Factories
{
    internal class StarBuzzFactory : ICoffeeFactory
    {
        public Beverage CreateBeverage(string type)
        {
            switch (type)
            {
                case "Espresso": return new Espresso();
                case "Doppio": return new Doppio();
                case "Lungo": return new Lungo();
                case "Macchiato": return new Macchiato();
                case "Corretta": return new Corretta();
                case "ConPanna": return new ConPanna();
                case "Cappucinno": return new Cappuccino();
                case "Americano": return new Americano();
                case "CaffeLatte": return new CaffeLatte();
                case "FlatWhite": return new FlatWhite();
                case "Romana": return new Romana();
                case "Morocchino": return new Morocchino();
                case "Mocha": return new Mocha();
                case "Bicerin": return new Bicerin();
                case "Breve": return new Breve();
                case "Rafcoffee": return new Rafcoffee();
                case "MeadRaf": return new MeadRaf();
                case "Galao": return new Galao();
                case "CaffeAffogato": return new CaffeAffogato();
                case "ViennaCoffee": return new ViennaCoffee();
                case "Glace": return new Glace();
                case "ChocolateMilk": return new ChocolateMilk();
                case "DemiCreme": return new DemiCreme();
                case "LatteMacchiato": return new LatteMacchiato();
                case "Freddo": return new Freddo();
                case "Frappuccino": return new Frappuccino();
                case "CaramelFrap": return new CaramelFrappuccino();
                case "Frappe": return new Frappe();
                case "IrishCoffee": return new IrishCoffee();

                default:
                    throw new ArgumentException(
                        "Onbekend drankje: " + type);
            }
        }

        public Beverage OrderCoffee(string type, Size size)
        {
            Beverage beverage = CreateBeverage(type);
            beverage.Size = size; return beverage;
        }
    }
}