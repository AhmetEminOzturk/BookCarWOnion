using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Queries.FooterAddressQueries;
using BookCarWOnion.Application.Features.Mediator.Results.FooterAddressResults;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler: IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;
        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }
        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var value=await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                Address = value.Address,
                Description = value.Description,
                Email = value.Email,
                FooterAddressID = value.FooterAddressID,
                Phone = value.Phone
            };
        }
    }
}