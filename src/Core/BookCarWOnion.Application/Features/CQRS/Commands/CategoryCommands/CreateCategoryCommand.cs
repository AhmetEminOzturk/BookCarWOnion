using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCarWOnion.Application.Features.CQRS.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}