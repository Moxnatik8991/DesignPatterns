using DesignPatterns.AbstractFactory.HeroFactories;
using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region AbstractFactory

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
