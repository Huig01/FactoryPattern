using FactoryPattern.Beverages;
using FactoryPattern.Factories;

StarBuzzFactory starBuzz = new StarBuzzFactory();

Beverage americano = starBuzz.OrderCoffee("Americano", Size.VENTI);

Console.WriteLine(americano);
