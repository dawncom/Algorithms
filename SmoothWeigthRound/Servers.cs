using System;
using System.Collections.Generic;
using System.Text;

namespace SmoothWeigthRound
{
    public class Servers
    {
        public Dictionary<string, Server> serversDic = new Dictionary<string, Server>()
        {
            { "192.168.1.1",new Server(5,5,"192.168.1.1") },
            { "192.168.1.2",new Server(1,1,"192.168.1.2") },
            { "192.168.1.3",new Server(1,1,"192.168.1.3") }
        };
    }
}
