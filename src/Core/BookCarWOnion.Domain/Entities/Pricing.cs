using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCarWOnion.Domain.Entities
{
    public class Pricing
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}