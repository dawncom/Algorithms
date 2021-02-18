using Common.Dto.LoadBlanceDto;
using System;

namespace FullRound
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(go());
            }
            Console.ReadKey();
        }
        private static int index;
        public static string go()
        {
            LBFullRoundDto servers = new LBFullRoundDto();

            if (index == servers.Servers.Count)
            {
                index = 0;
            }
            return servers.Servers[index++];
        }
    }
}
