using System.Collections.Generic;
using System.Linq;
using MimeKit;

namespace Core.Utilities.EmailSender
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x =>  MailboxAddress.Parse( x)));
            Subject = subject;
            Content = content;

        }
    }
}