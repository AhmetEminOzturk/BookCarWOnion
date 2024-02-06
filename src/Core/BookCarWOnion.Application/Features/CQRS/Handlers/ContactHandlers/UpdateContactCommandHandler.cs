using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.CQRS.Commands.ContactCommands;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;

namespace BookCarWOnion.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Name = command.Name;
            values.Email = command.Email;
            values.Message = command.Message;
            values.SendDate = command.SendDate;
            values.Subject = command.Subject;
            await _repository.UpdateAsync(values);
        }
    }
}