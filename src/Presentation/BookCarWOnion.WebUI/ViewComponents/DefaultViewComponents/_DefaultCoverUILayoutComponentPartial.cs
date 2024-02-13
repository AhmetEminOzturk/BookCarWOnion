using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.DTOs.Banner.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookCarWOnion.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverUILayoutComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _DefaultCoverUILayoutComponentPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ResultBannerResponse>>("http://localhost:5276/api/Banners");
            return View(response);
        }
    }
}