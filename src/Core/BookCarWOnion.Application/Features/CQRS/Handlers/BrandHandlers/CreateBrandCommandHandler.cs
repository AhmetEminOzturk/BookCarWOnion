using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.CQRS.Commands.BrandCommands;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;

namespace BookCarWOnion.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;
        public CreateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateBrandCommand command)
        {
            await _repository.CreateAsync(new Brand
            {
                Name = command.Name
            });
        }
    }
}