using System;
using System.Collections.Generic;

namespace KetamaHash
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nodes = new List<string> 
            {
                "127.1.1.1",
                "127.1.1.2",
                "127.1.1.3",
                "127.1.1.4"
            };
            KetamaNodeLocator ketamaNode = new KetamaNodeLocator(nodes, 8);

            for (int i = 0; i < 30; i++)
            {
                var rt = ketamaNode.GetPrimary(nodes[i % 4]);
                Console.WriteLine(rt);
            }
            
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
