using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.Features.Mediator.Queries.TestimonialQueries;
using BookCarWOnion.Application.Features.Mediator.Results.TestimonialResults;
using BookCarWOnion.Application.Interfaces;
using BookCarWOnion.Domain.Entities;
using MediatR;

namespace BookCarWOnion.Application.Features.Mediator.Handlers.TestimonialHandlers
{
     public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
 {
     private readonly IRepository<Testimonial> _repository;
     public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
     {
         _repository = repository;
     }
     public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
     {
         var values = await _repository.GetAllAsync();
         return values.Select(x => new GetTestimonialQueryResult
         {
             Name = x.Name,
             TestimonialID = x.TestimonialID,
             ImageUrl = x.ImageUrl,
             Title = x.Title,
             Comment = x.Comment
         }).ToList();
     }
 }
}