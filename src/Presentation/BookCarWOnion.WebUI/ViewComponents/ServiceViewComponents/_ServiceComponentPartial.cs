using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.DTOs.Service.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookCarWOnion.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceComponentPartial: ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _ServiceComponentPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ResultServiceResponse>>("http://localhost:5276/api/Services");
            return View(response);
        }
    }
}