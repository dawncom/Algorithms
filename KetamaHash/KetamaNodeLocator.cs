using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KetamaHash
{
    public class KetamaNodeLocator
    {
        private SortedList<long, string> ketamaNodes = new SortedList<long, string>();

        private HashAlgorithm hashAlg;

        private int numReps = 160;

        public KetamaNodeLocator(List<string> nodes, int nodeCopies)
        {
            ketamaNodes = new SortedList<long, string>();
            numReps = nodeCopies;

            //对所有节点，生成nCopies个虚拟节点
            foreach (var node in nodes)
            {
                //每四个虚拟节点为一组
                for (int i = 0; i < numReps / 4; i++)
                {
                    //getKeyForNode方法为这组虚拟节点得到唯一名称
                    byte[] bigest = HashAlgorithm.computeMd5(node + i);

                    //md5是一个16字节长度的数组，将16字节的数组每四个字节一组，分别对应一个虚拟节点（所以按每四个虚拟节点为一组）
                    for (int j = 0; j < 4; j++)
                    {
                        long m = HashAlgorithm.hash(bigest, j);
                        ketamaNodes[m] = node;
                    }
                }
            }
        }

        public string GetPrimary(string k)
        {
            byte[] digest = HashAlgorithm.computeMd5(k);
            string rv = GetNodeForKey(HashAlgorithm.hash(digest, 0));

            return rv;
        }

        string GetNodeForKey(long hash)
        {
            string rv;
            long key = hash;

            //如果找到这个节点，直接取节点返回
            if (!ketamaNodes.ContainsKey(key))
            {
                var tailMap = from cool in ketamaNodes
                              where cool.Key > hash
                              select new { cool.Key };
                if (tailMap == null || tailMap.Count() == 0)
                {
                    key = ketamaNodes.FirstOrDefault().Key;
                }
                else
                {
                    key = tailMap.FirstOrDefault().Key;
                }
            }

            rv = ketamaNodes[key];

            return rv;
        }
    }
}
