using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCarWOnion.Application.Features.Mediator.Results.PricingResults
{
    public class GetPricingByIdQueryResult
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
    }
}