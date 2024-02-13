using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookCarWOnion.Application.DTOs.Contact.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookCarWOnion.WebUI.Controllers
{
    public class ContactsController : Controller
    {
        private readonly HttpClient _httpClient;

        public ContactsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactRequest createContact)
        {
            createContact.SendDate = DateTime.Now;
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5276/api/Contacts", createContact);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}