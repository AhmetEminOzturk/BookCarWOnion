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
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _repository;
        public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetPricingByIdQueryResult
            {
                PricingID = values.PricingID,
                Name = values.Name
            };
        }
    }
}