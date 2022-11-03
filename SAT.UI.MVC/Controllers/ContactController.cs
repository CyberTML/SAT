using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SAT.UI.MVC.Models;
using MailKit.Net.Smtp;

namespace SAT.UI.MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // For functionality, would need to enable email within Smarter ASP.


        // Credentials for appsettings.json
        private readonly IConfiguration _config;
        public ContactController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost]
        public IActionResult Contact(ContactViewModel cvm)
        {
            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            // Recieved Email Message
            string message = $"New Email from Contact Form.<br />" +
                             $"Sender: {cvm.FirstName} {cvm.LastName}<br />" +
                             $"Email Address: {cvm.Email}<br />" +
                             $"Subject: {cvm.Subject}<br />" +
                             $"Message: {cvm.Message}";


            // Sorting/Transporting Email Info
            var cm = new MimeMessage();            
            cm.From.Add(new MailboxAddress("Sender", _config.GetValue<string>("Credentials:Email:User"))); // Email User Credentials
            cm.To.Add(new MailboxAddress("Recipient", _config.GetValue<string>("Credentials:Email:Recipient"))); // Recipient Email
            cm.Subject = cvm.Subject; // Store Subject --> cvm Object
            cm.Body = new TextPart("HTML") { Text = message }; // Body formatted with string
            // Could set Priority Here
            cm.ReplyTo.Add(new MailboxAddress("User", cvm.Email)); // Reply directly to sender

            using (var client = new SmtpClient())
            {
                client.Connect(_config.GetValue<string>("Credentials:Email:Client"));
                client.Authenticate(
                    _config.GetValue<string>("Credentials:Email:User"),
                    _config.GetValue<string>("Credentials:Email:Password")
                    );

                try
                {
                    client.Send(cm);
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = $"Message failed to send, Please try again...(Error Message: {ex.StackTrace})";
                    return View(cvm);
                }
            }

            return View("ConfirmedEmail", cvm);
        }
    }
}
