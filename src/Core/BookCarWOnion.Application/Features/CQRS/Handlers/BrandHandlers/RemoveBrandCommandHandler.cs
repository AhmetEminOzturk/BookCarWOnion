using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.CQRS.Commands.BrandCommands;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;

namespace BookCarWOnion.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;
        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBrandCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}