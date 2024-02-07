using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}