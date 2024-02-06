using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.CQRS.Results.AboutResults;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;

namespace BookCarWOnion.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAboutQueryResut>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetAboutQueryResut
            {
                AboutID = x.AboutID,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}