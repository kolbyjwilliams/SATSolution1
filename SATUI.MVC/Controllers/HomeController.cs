using SATUI.MVC.Models;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using System;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel cvm)
        {
            if (ModelState.IsValid)
            {
                string body = $"{cvm.Name} has sent you the following message:</br>" +
                    $"{cvm.Message} <strong>From the email address of: </strong>{cvm.Email}";

                MailMessage m = new MailMessage("xavier@xaviersgiftedchildren.com","woodwardlex@gmail.com",cvm.Subject,body);

                m.IsBodyHtml = true;
                m.Priority = MailPriority.High;
                m.ReplyToList.Add(cvm.Email);

                SmtpClient client = new SmtpClient("mail.xaviersgiftedchildren.com.ext");
                client.Credentials = new NetworkCredential("woodwardlex@gmail.com", "Jenny1997");
                try
                {
                    client.Send(m);
                }
                catch (Exception e)
                {
                    ViewBag.Message = e.StackTrace;

                }
                return View("EmailConfirmation");
            }
            return View(cvm);
        }
    }
}
