using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Xml;
using System.Web;

namespace TheDivine.Shared
{
	public class ContactFormModel
	{
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string Message { get; set; } = "";
        public string Product { get; set; } = "";


        public string ToMail()
        {
            string mail = "Nazwisko: <b>" + Name + "</b><br/>";
            mail += "Email: <b>" + Email + "</b><br/>";
            if (Product.Length > 0)
            {
                mail += "Wybieram: <b>" + Product + "</b><br/>";
            }
            mail += "<br/>";
            mail += Message;

            return mail;
        }
    }
}
