using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Languages
{
    public interface ILanguage
    {
        void Build();
        void Execute();
    }
}
