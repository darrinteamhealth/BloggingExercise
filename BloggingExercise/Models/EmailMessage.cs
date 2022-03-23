using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BloggingExercise.Models
{
    public class EmailMessage
    {
        public EmailMessage(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }

        public string From { get; set; }
        public string FromDisplayName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string IsBodyHtml { get; set; }
        public List<string> To { get; set; }
        public List<string> Bcc { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
