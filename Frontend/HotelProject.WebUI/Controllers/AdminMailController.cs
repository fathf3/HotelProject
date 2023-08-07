using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("admin", "mail");
            mimeMessage.From.Add(mailboxAddress);
            MailboxAddress mailboxAddressTo = new MailboxAddress("user", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subjet;


            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 578, false);
            client.Authenticate("mail", password: "password");
            client.Send(mimeMessage);
            client.Disconnect(true);




            return View();

        }


    }
}
