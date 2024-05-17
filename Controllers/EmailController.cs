using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System.Net.Mail;
using System.Net;

namespace TheDivine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult Send(string from, string to, string subject, string html)
        {

			/*
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.poczta.onet.pl", 587, SecureSocketOptions.Auto);
            smtp.Authenticate("mail@mail.pl", "Password");

            smtp.Send(email);

            smtp.Disconnect(true);
            return Ok();
            */

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			var email = new MimeMessage();
			email.From.Add(MailboxAddress.Parse(from));
			email.To.Add(MailboxAddress.Parse(to));
			email.Subject = subject;
			email.Body = new TextPart(TextFormat.Html) { Text = html };

			using (var smtpClient = new MailKit.Net.Smtp.SmtpClient())
			{
				smtpClient.Connect("smtp.poczta.onet.pl", 25, SecureSocketOptions.StartTls);
				smtpClient.Authenticate("mail@mail.pl", "Password");

				smtpClient.Send(email);
				smtpClient.Disconnect(true);
				return Ok();

			}
		}
    }
}
