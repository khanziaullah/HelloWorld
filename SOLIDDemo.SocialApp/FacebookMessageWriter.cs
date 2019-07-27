using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDemo.SocialApp
{
    class FacebookMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine("Posting to facebook: {0}", message);
        }
    }
}
