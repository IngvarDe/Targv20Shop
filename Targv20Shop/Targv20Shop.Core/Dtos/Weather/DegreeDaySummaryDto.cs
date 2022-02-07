using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class DegreeDaySummaryDto
    {
        public HeatingDto Heating { get; set; }
        public CoolingDto Cooling { get; set; }
    }
}
