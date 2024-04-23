using DesignPatterns.Bridge.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Programmers
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang): base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}
