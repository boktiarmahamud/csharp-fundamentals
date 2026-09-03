using DIServiceLifetime.Models;
using DIServiceLifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIServiceLifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IMessageService _messageService2;

        public HomeController(IMessageService messageService, IMessageService messageService2)
        {
            ViewBag.MessageService = "Life time of Transient service";
            _messageService = messageService;
            _messageService2 = messageService2;
        }

        public IActionResult Index()
        {
            return Content(
                $"This is a Transient Service\n" +
                $"MessageService1 ID: {_messageService.GetId()}\n" +
                $"MessageService2 ID: {_messageService2.GetId()}"
            );
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
