using System;
using System.Linq;
namespace SmoothWeigthRound
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(go());
            }
            Console.ReadKey();
        }

        private static Servers servers = new Servers();

        public static string go()
        {
            Server maxWeightServer = null;
            int allWeight = servers.serversDic.Select(t => t.Value.getWeight()).Sum();

            foreach (var item in servers.serversDic)
            {
                var currentServer = item.Value;
                if (maxWeightServer == null || currentServer.getCurrentWeight() > maxWeightServer.getCurrentWeight())
                {
                    maxWeightServer = currentServer;
                }
            }

            if (maxWeightServer != null)
            {
                maxWeightServer.setCurrentWeight(maxWeightServer.getCurrentWeight() - allWeight);

            }

            foreach (var item in servers.serversDic)
            {
                var currentServer = item.Value;
                currentServer.setCurrentWeight(currentServer.getCurrentWeight() + currentServer.getWeight());
            }
            return maxWeightServer.getIp();
        }
    }
}
