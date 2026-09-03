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

        private readonly IScopedMessageService _scopedMessageService;
        private readonly IScopedMessageService _scopedMessageService2;

        private readonly ISingletonMessageService _singletonMessageService;
        private readonly ISingletonMessageService _singletonMessageService2;   

        public HomeController(IMessageService messageService, IMessageService messageService2, 
            IScopedMessageService scopedMessageService, IScopedMessageService scopedMessageService2,
            ISingletonMessageService singleton1, ISingletonMessageService singleton2)
        {
            
            _messageService = messageService;
            _messageService2 = messageService2;

            
            _scopedMessageService = scopedMessageService;
            _scopedMessageService2 = scopedMessageService2;

            _singletonMessageService = singleton1;
            _singletonMessageService2 = singleton2;
        }

        public IActionResult Index()
        {
            return Content(
                $"This is a Transient Service\n" +
                $"MessageService1 ID: {_messageService.GetId()}\n" +
                $"MessageService2 ID: {_messageService2.GetId()}\n" +
                $"This is a Scoped Service\n" +
                $"ScopedMessageService1 ID: {_scopedMessageService.GetId()}\n" +
                $"ScopedMessageService2 ID: {_scopedMessageService2.GetId()}\n" +
                $"This is a Singleton Service\n" +
                $"SingletonMessageService1 ID: {_singletonMessageService.GetId()}\n" +
                $"SingletonMessageService2 ID: {_singletonMessageService2.GetId()}"
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
