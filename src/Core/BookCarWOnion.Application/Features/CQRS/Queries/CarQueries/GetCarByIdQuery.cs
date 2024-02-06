using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCarWOnion.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public int Id { get; set; }

        public GetCarByIdQuery(int id)
        {
            Id = id;
        }
    }
}