using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plukliste.Infrastukture.console.Interface
{
    internal class LoggingColor : ILoggingColor
    {
        public void Color(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
