using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mCPA.Models;
using System.Configuration;
using System.Net.Mail;

namespace mCPA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {            
            return View();
        }

        public ActionResult Contact()
        {           
            return View();
        }

        public ActionResult Disclaimer()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        //public ActionResult EmailConfirmation()
        //{
        //    return View();
        //}

        public ActionResult Sitemap()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmailConfirmation(EmailModel model)
        {
            if (!ModelState.IsValid) return View("Contact");
            string subject = ConfigurationManager.AppSettings["Email_Subject"].ToString();
            string from = ConfigurationManager.AppSettings["Email_Sender"].ToString();
            string to = ConfigurationManager.AppSettings["Email_Recipient"].ToString();
            
            string body = "";
            body += "Name: " + model.Name + "<br>";
            body += "Email: " + model.Email + "<br>";
            body += "Phone: " + model.Phone + "<br>";
            body += "Message: " + model.Message + "<br>";

            MailMessage mailObj = new MailMessage(from, to, subject, body);
            mailObj.IsBodyHtml = true;
            //SmtpClient SMTPServer = new SmtpClient(host);
            //SMTPServer.Credentials
            //SMTPServer.Port = Convert.ToInt32(port);

            SmtpClient SMTPServer = new SmtpClient();

            try
            {
                SMTPServer.Send(mailObj);
                return View();
            }
            catch (Exception ex)
            {
                NotifyAdmin(ex.Message);
                throw;
            }
            //return View();
        }

        private void NotifyAdmin(string message)
        {
            //string host = ConfigurationManager.AppSettings["SMTP_Host"].ToString();
            //string port = ConfigurationManager.AppSettings["SMTP_Port"].ToString();
            string subject = ConfigurationManager.AppSettings["Web_Error_Subject"].ToString();
            string from = ConfigurationManager.AppSettings["Email_Sender"].ToString();
            string to = ConfigurationManager.AppSettings["Admin_Email"].ToString();
            string body = message;

            MailMessage mailObj = new MailMessage(from, to, subject, body);
            mailObj.IsBodyHtml = true;
            //SmtpClient SMTPServer = new SmtpClient(host);
            //SMTPServer.Port = Convert.ToInt32(port);

            SmtpClient SMTPServer = new SmtpClient();

            try
            {
                SMTPServer.Send(mailObj);
            }
            catch (Exception ex)
            {

            }
        }
    }
}