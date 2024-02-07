using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand :IRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}