using Common.Dto.LoadBlanceDto;
using System;

namespace FullRandom
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

        
        public static string go()
        {
            LBFullRandomServerDto servers = new LBFullRandomServerDto();
            Random random = new Random();

            var number = random.Next(servers.Servers.Count);

            var ipStr = servers.Servers[number].ToString();
            return ipStr;
        }
    }
}
