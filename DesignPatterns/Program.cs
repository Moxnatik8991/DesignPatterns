using DesignPatterns.AbstractFactory.HeroFactories;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region AbstractFactory

            //https://metanit.com/sharp/patterns/2.2.php
            //Hero elf = new Hero(new ElfFactory());
            //elf.Hit();
            //elf.Run();

            //Hero voin = new Hero(new VoinFactory());
            //voin.Hit();
            //voin.Run();

            #endregion

            #region Adapter

            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel();
            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
