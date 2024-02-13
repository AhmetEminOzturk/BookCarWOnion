using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCarWOnion.Application.DTOs.Location.Requests
{
    public class UpdateLocationRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}