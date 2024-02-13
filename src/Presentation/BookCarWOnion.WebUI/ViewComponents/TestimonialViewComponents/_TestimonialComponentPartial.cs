using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.DTOs.Testimonial.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookCarWOnion.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial: ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _TestimonialComponentPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ResultTestimonialResponse>>("http://localhost:5276/api/Testimonials");
            return View(response);
        }
    }
}