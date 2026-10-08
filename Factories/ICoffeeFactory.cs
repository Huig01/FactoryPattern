using FactoryPattern.Beverages;

namespace FactoryPattern.Factories
{
    internal interface ICoffeeFactory
    {
        Beverage CreateBeverage(string type);
    }
}