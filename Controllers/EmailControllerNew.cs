using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;


namespace TheDivine.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmailControllerNew : Controller
	{

		[HttpPost]
		public IActionResult Send(string from, string to, string subject, string html)
		{
			MailMessage mm = new MailMessage();
            System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient("smtp.poczta.onet.pl");
			mm.From = new MailAddress(from);
			mm.To.Add(to);
			mm.Subject = subject;
			mm.Body = html;
			sc.Port = 587;
			sc.Credentials = new System.Net.NetworkCredential(from, "Password");
			sc.EnableSsl = true;
			sc.Send(mm);
			return Ok();

		}
	}
}
