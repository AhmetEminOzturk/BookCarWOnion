using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCarWOnion.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIdQuery
    {
        public int Id { get; set; }
        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }
    }
}