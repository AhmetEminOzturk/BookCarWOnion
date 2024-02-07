using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Queries.LocationQueries;
using BookCarWOnion.Application.Features.Mediator.Results.LocationResults;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetLocationQueryResult{
                Name = x.Name,
                LocationID = x.LocationID
            }).ToList();
        }
    }
}