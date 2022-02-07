using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class SunDto
    {
        public string Rise { get; set; }
        public int EpochRise { get; set; }
        public string Set { get; set; }
        public int EpochSet { get; set; }
    }
}
