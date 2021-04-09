using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BadWeather badWeather = new BadWeather();
            GoodWeather goodWeather = new GoodWeather();

            IRainable rainable = badWeather as IRainable;
            rainable.BadMethod();
            IWindable windable = badWeather as IWindable;
            windable.BadMethod();

            ISunable sunable = goodWeather as ISunable;
            sunable.GoodMethod();
            IWarmable warmable = goodWeather as IWarmable;
            warmable.GoodMethod();

            Console.ReadKey();
        }
    }
    interface IRainable
    {
        void BadMethod();
    }
    interface IWindable : IRainable
    {
        new void BadMethod();
    }

    class BadWeather : IWindable
    {
        void IRainable.BadMethod()
        {
            Console.WriteLine("Is Raining: ");
        }
        void IWindable.BadMethod()
        {
            Console.WriteLine("Is Windy: ");
        }
    }

    interface ISunable
    {
        void GoodMethod();
    }
    interface IWarmable : ISunable
    {
        new void GoodMethod();
    }
    
    class GoodWeather : IWarmable
    {
        void ISunable.GoodMethod()
        {
            Console.WriteLine("Is Sunny: ");
        }
        void IWarmable.GoodMethod()
        {
            Console.WriteLine("Is Warming: ");
        }
    }
}