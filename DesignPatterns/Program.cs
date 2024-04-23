using DesignPatterns.AbstractFactory.HeroFactories;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge.Programmers;
using DesignPatterns.Bridge.Languages;

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

            //https://metanit.com/sharp/patterns/4.2.php

            // путешественник
            //Driver driver = new Driver();
            //// машина
            //Auto auto = new Auto();
            //// отправляемся в путешествие
            //driver.Travel(auto);
            //// встретились пески, надо использовать верблюда
            //Camel camel = new Camel();
            //// используем адаптер
            //ITransport camelTransport = new CamelToTransportAdapter(camel);
            //// продолжаем путь по пескам пустыни
            //driver.Travel(camelTransport);

            #endregion

            #region Bridge

            //https://metanit.com/sharp/patterns/4.6.php

            // создаем нового программиста, он работает с с++
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
