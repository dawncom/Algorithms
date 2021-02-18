using Common.Dto.LoadBlanceDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WeightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(go2());
            }
            Console.ReadKey();
        }

        public static string go()
        {
            LBWeightRamdomDto serversDic = new LBWeightRamdomDto();

            List<string> ipList = new List<string>();

            //根据比例将Ip放到一个list中，再随机取
            foreach (var item in serversDic.ServersDic)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    ipList.Add(item.Key);
                }
            }

            int allWeigth = serversDic.ServersDic.Select(t => t.Value).Sum();

            Random random = new Random();

            var number = random.Next(allWeigth);

            var ipStr = ipList[number].ToString();
            return ipStr;
        }

        public static string go2()
        {
            LBWeightRamdomDto ipList = new LBWeightRamdomDto();
            Random random = new Random();

            var allWeigth = ipList.ServersDic.Select(t => t.Value).Sum();

            var number = random.Next(allWeigth);

            foreach (var item in ipList.ServersDic)
            {
                if (item.Value > number)
                {
                    return item.Key;
                }
                number -= item.Value;
            }

            return "";
        }
    }
}
