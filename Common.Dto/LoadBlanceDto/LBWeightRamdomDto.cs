using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto.LoadBlanceDto
{
    public class LBWeightRamdomDto
    {
        public Dictionary<string, int> ServersDic = new Dictionary<string, int>()
        {
            { "192.168.1.1",2},{ "192.168.1.2",7},{"192.168.1.3",1 }
        };
    }
}
