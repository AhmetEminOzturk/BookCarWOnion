using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Results.LocationResults;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery: IRequest<List<GetLocationQueryResult>>
    {
        
    }
}