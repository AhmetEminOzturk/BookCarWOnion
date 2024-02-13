using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.DTOs.FooterAddress.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookCarWOnion.WebUI.ViewComponents.FooterAddressComponents
{
    public class _FooterAddressComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _FooterAddressComponentPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ResultFooterAddressResponse>>("http://localhost:5276/api/FooterAddresses");
            return View(response);
        }
    }
}