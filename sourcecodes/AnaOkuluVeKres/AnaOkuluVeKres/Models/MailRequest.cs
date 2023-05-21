namespace AnaOkuluVeKres.Models
{
    public class MailRequest
    {
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string ReciverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
