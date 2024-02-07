using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Queries.PricingQueries;
using BookCarWOnion.Application.Features.Mediator.Results.PricingResults;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;
        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPricingQueryResult
            {
                Name = x.Name,
                PricingID = x.PricingID
            }).ToList();
        }
    }
}