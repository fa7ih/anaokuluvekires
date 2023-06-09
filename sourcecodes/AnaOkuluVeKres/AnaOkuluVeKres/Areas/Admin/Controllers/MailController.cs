﻿using AnaOkuluVeKres.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "anaokuluvekres.yonetici@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReciverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody= mailRequest.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.Subject;
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("anaokuluvekres.yonetici@gmail.com", "ymukgrnqnccufekm");
            client.Send(mimeMessage);
            client.Disconnect(true);
            TempData["SuccessMessage"] = "Mail başarıyla gönderildi.";
            return View();
        }
    }
}
