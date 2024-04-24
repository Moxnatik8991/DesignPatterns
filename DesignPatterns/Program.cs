using DesignPatterns.AbstractFactory.HeroFactories;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge.Programmers;
using DesignPatterns.Bridge.Languages;
using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;

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

            //// создаем нового программиста, он работает с с++
            //Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            //freelancer.DoWork();
            //freelancer.EarnMoney();

            //// пришел новый заказ, но теперь нужен c#
            //freelancer.Language = new CSharpLanguage();
            //freelancer.DoWork();
            //freelancer.EarnMoney();

            #endregion

            #region Builder

            //https://metanit.com/sharp/patterns/2.5.php

            //// содаем объект пекаря
            //Baker baker = new Baker();
            //// создаем билдер для ржаного хлеба
            //BreadBuilder builder = new RyeBreadBuilder();
            //// выпекаем
            //Bread ryeBread = baker.Bake(builder);
            //Console.WriteLine(ryeBread.ToString());
            //// cоздаем билдер для пшеничного хлеба
            //builder = new WheatBreadBuilder();
            //Bread wheatBread = baker.Bake(builder);
            //Console.WriteLine(wheatBread.ToString());

            #endregion

            #region Chain of responsibility

            //https://metanit.com/sharp/patterns/3.7.php


            //Receiver receiver = new Receiver(false, true, true);

            //PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            //PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            //PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            //bankPaymentHandler.Successor = paypalPaymentHandler;
            //paypalPaymentHandler.Successor = moneyPaymentHadler;

            //bankPaymentHandler.Handle(receiver);

            #endregion

            #region Command

            //https://metanit.com/sharp/patterns/3.3.php

            //part1
            //Pult pult = new Pult();
            //TV tv = new TV();
            //pult.SetCommand(new TVOnCommand(tv));
            //pult.PressButton();
            //pult.PressUndo();

            //Microwave microwave = new Microwave();
            //// 5000 - время нагрева пищи
            //pult.SetCommand(new MicrowaveCommand(microwave, 5000));
            //pult.PressButton();


            //part2
            TV tv = new TV();
            Volume volume = new Volume();
            MultiPult mPult = new MultiPult();
            mPult.SetCommand(0, new TVOnCommand(tv));
            mPult.SetCommand(1, new VolumeCommand(volume));
            // включаем телевизор
            mPult.PressButton(0);
            // увеличиваем громкость
            mPult.PressButton(1);
            mPult.PressButton(1);
            mPult.PressButton(1);
            // действия отмены
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
