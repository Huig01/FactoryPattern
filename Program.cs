using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.Size = Size.GRANDE;
            PrintBeverage(espresso);

            Beverage dopio = new Espresso();
            dopio.Size = Size.VENTI;
            dopio = new CondimentEspresso(dopio);
            PrintBeverage(dopio);

            Beverage lungo = new Espresso();
            //lungo.Size = Size.TALL;
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage macchiato = new Espresso();
            lungo.Size = Size.TALL;
            macchiato = new MilkFoam(macchiato);            
            PrintBeverage(macchiato);

            //Beverage Corretta = new Espresso();
            //Corretta = new Liqour(Corretta);
            //PrintBeverage(macchiato);

            //Beverage ConPanna = new Espresso();
            //ConPanna = new Whip(ConPanna);
            //PrintBeverage(ConPanna);

            //Beverage Cappucinno = new Espresso();
            //Cappucinno = new SteamedMilk(Cappucinno);
            //Cappucinno = new MilkFoam(Cappucinno);
            //PrintBeverage(Cappucinno);

            //Beverage Americano = new Espresso();
            //Americano = new Water(Americano);
            //Americano = new Water(Americano);
            //Americano = new Mocha(Americano);
            //Americano = new Whip(Americano);
            //Americano.cost();
            //PrintBeverage(Americano);

            //Beverage CafféLatte = new Espresso();
            //CafféLatte = new SteamedMilk(CafféLatte);
            //CafféLatte = new SteamedMilk(CafféLatte);
            //CafféLatte = new MilkFoam(CafféLatte);
            //PrintBeverage(CafféLatte);

            //Beverage FlatWhite = new Espresso();
            //FlatWhite = new SteamedMilk(FlatWhite);
            //FlatWhite = new SteamedMilk(FlatWhite);
            //PrintBeverage(FlatWhite);

            //Beverage Romana = new Espresso();
            //Romana = new Lemon(Romana);
            //PrintBeverage(Romana);

            //Beverage Morocchino = new Espresso();
            //Morocchino = new CondimentChocolate(Morocchino);
            //Morocchino = new MilkFoam(Morocchino);
            //PrintBeverage(Morocchino);

            //Beverage Mocha = new Espresso();
            //Mocha = new CondimentChocolate(Mocha);
            //Mocha = new SteamedMilk(Mocha);
            //PrintBeverage(Mocha);

            //Beverage Bicerin = new Espresso();
            //Bicerin = new BlackChocolate(Bicerin);
            //Bicerin = new WhiteChocolate(Bicerin);
            //Bicerin = new Whip(Bicerin);
            //PrintBeverage(Bicerin);

            //Beverage Breve = new Espresso();
            //Breve = new MilkFoam(Breve);
            //Breve = new HalfMilk(Breve);
            //PrintBeverage(Breve);

            //Beverage RafCoffee = new Espresso();
            //RafCoffee = new VanillaSuger(RafCoffee);
            //RafCoffee = new Cream(RafCoffee);
            //PrintBeverage(RafCoffee);

            //Beverage MeadRaf = new Espresso();
            //MeadRaf = new Honey(MeadRaf);
            //MeadRaf = new Cream(MeadRaf);
            //PrintBeverage(MeadRaf);

            //Beverage Galao = new Espresso();
            //Galao = new MilkFoam(Galao);
            //Galao = new MilkFoam(Galao);
            //PrintBeverage(Galao);

            //Beverage CafféAffogato = new Espresso();
            //CafféAffogato = new CondimentEspresso(CafféAffogato);
            //CafféAffogato = new IceCream(CafféAffogato);
            //PrintBeverage(CafféAffogato);

            //Beverage ViennaCoffee = new Espresso();
            //ViennaCoffee = new CondimentEspresso(ViennaCoffee);
            //ViennaCoffee = new Whip(ViennaCoffee);
            //ViennaCoffee = new Whip(ViennaCoffee);
            //PrintBeverage(ViennaCoffee);

            //Beverage Glace = new Espresso();
            //Glace = new IceCream(Glace);
            //PrintBeverage(Glace);

            //Beverage ChocolateMilk = new Chocolate();
            //ChocolateMilk = new Milk(ChocolateMilk);
            //ChocolateMilk = new Milk(ChocolateMilk);
            //PrintBeverage(ChocolateMilk);

            //Beverage DemiCréme = new Espresso();
            //DemiCréme = new CondimentEspresso(DemiCréme);
            //DemiCréme = new Cream(DemiCréme);
            //DemiCréme = new Cream(DemiCréme);
            //PrintBeverage(DemiCréme);

            //Beverage LatteMacchiato = new Espresso();
            //LatteMacchiato = new SteamedMilk(LatteMacchiato);
            //LatteMacchiato = new SteamedMilk(LatteMacchiato);
            //LatteMacchiato = new MilkFoam(LatteMacchiato);
            //PrintBeverage(LatteMacchiato);

            //Beverage Freddo = new Espresso();
            //Freddo = new Liqour(Freddo);
            //Freddo = new Ice(Freddo);
            //PrintBeverage(Freddo);

            //Beverage Frappuccino = new Espresso();
            //Frappuccino = new Ice(Frappuccino);
            //Frappuccino = new SteamedMilk(Frappuccino);
            //Frappuccino = new Whip(Frappuccino);
            //PrintBeverage(Frappuccino);

            //Beverage CaramelFrappuccino = new Espresso();
            //CaramelFrappuccino = new Ice(CaramelFrappuccino);
            //CaramelFrappuccino = new SteamedMilk(CaramelFrappuccino);
            //CaramelFrappuccino = new SteamedMilk(CaramelFrappuccino);
            //CaramelFrappuccino = new Cream(CaramelFrappuccino);
            //CaramelFrappuccino = new Syrup(CaramelFrappuccino);
            //PrintBeverage(CaramelFrappuccino);

            //Beverage Frappe = new Espresso();
            //Frappe = new SteamedMilk(Frappe);
            //Frappe = new SteamedMilk(Frappe);
            //Frappe = new IceCream(Frappe);
            //PrintBeverage(Frappe);

            //Beverage IrishCoffee = new Espresso();
            //IrishCoffee = new CondimentEspresso(IrishCoffee);
            //IrishCoffee = new Whiskey(IrishCoffee);
            //IrishCoffee = new Whip(IrishCoffee);
            //PrintBeverage(IrishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}