using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDemo.ConsoleApp
{
    class ConsoleMessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            return "Hello, World";
        }
    }
}
