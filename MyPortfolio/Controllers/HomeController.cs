using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1, Title = "Test", Image = "01.jpg", Description = "Test Model-View"
            },
            new Portfolio
            {
                Id = 2, Title = "Contact", Image = "02.jpg", Description = "Description of Contacts"
            },
            new Portfolio
            {
                Id = 3, Title = "Privacy", Image = "03.jpg", Description = "Description of Privacy"
            },
            new Portfolio
            {
                Id = 4, Title = "SocialMedia", Image = "04.jpg", Description = "Description of Social"
            },
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی مهدی سیدی خوش آمدید :)";

            ViewData["headingText"] = "این سایت برای تست قابلیت های ریزور پیج زده شده است ";

            return View(_portfolios);
        }


        public IActionResult Contact()
        {
            var contact = new Contact
            {
                Email = "Mahdisayyedi53@gmail.com",
                Github = "https://github.com/Mahdiseyedi",
                Mobile = "09961351401"
            };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
