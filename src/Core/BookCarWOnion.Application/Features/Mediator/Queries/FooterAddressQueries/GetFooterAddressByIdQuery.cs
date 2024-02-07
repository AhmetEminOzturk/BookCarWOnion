using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFooterAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}