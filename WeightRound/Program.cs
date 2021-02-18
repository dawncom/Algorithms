using Common.Dto.LoadBlanceDto;
using System;
using System.Linq;
namespace WeightRound
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

        static int index;
        static LBWeightRoundDto serversDic = new LBWeightRoundDto();
        public static string go()
        {
            var allWeight = serversDic.ServersDic.Select(t => t.Value).Sum();

            int number = (index++) % allWeight;
            foreach (var item in serversDic.ServersDic)
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
