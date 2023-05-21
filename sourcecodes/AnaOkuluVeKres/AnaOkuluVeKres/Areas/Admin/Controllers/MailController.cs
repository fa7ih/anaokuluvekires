using AnaOkuluVeKres.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class MailController : Controller
    {
        [HttpGet] 
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","fk491642@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReciverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            //mimeMessage.Body = mailRequest.Body;
            mimeMessage.Subject = mailRequest.Subject;
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("fk491642@gmail.com", "fetih1453");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
