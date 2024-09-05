using Microsoft.AspNetCore.Mvc;
using SupportApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SupportApp.Controllers
{
    public class SupportRequestController : Controller
    {
        private static List<SupportRequest> requests = new List<SupportRequest>();

        public IActionResult Index()
        {
            return View(requests);
        }

        [HttpPost]
        public IActionResult AddRequest(string customerName, string description, string? notes)
        {
            var newRequest = new SupportRequest 
            { 
                Id = requests.Count + 1, 
                CustomerName = customerName, 
                Description = description, 
                IsResolved = false,
                Notes = notes
            };
            requests.Insert(0, newRequest); // Insert at the beginning of the list
            return Json(newRequest); // Return JSON instead of redirecting
        }

        [HttpPost]
        public IActionResult ResolveRequest(int id)
        {
            var request = requests.FirstOrDefault(r => r.Id == id);
            if (request != null)
            {
                request.IsResolved = true;
            }
            return Json(new { success = true, id = id }); // Return JSON response
        }
    }
}