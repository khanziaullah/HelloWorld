using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDemo.SocialApp
{
    class TwitterMessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            //throw new ApplicationException("Failed to connect to twitter.");
            return "#HelloWorld";
        }
    }
}
