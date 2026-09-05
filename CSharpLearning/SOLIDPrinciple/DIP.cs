using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    public interface IMessageService
    {
        public void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    public class SMSService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class Notificaction
    {
        private readonly IMessageService _messageService;

        public Notificaction(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void SendMessage(string message)
        {
            _messageService.SendMessage(message);
        }
    }
    internal class DIP
    {
        public static void Main(string[] args)
        {
            IMessageService emailService = new EmailService();
            Notificaction notification = new Notificaction(emailService);
            notification.SendMessage("Hello via Email!");

            IMessageService smsService = new SMSService();
            Notificaction notification2 = new Notificaction(smsService);
            notification2.SendMessage("Hello via SMS!");

        }
    }
}
