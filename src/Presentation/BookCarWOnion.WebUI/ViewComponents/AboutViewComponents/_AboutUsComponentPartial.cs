using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.DTOs.About.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookCarWOnion.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _AboutUsComponentPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ResultAboutResponse>>("http://localhost:5276/api/Abouts");
            return View(response);
        }
    }
}