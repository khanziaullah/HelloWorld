using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDemo.Logic
{
    public class Startup
    {
        IMessageReader _reader;
        IMessageWriter _writer;

        public Startup(IMessageReader reader, IMessageWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void Run()
        {
            _writer.WriteMessage(_reader.ReadMessage());
        }
    }
}
