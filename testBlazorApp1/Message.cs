namespace testBlazorApp1
{
    public class Message
    {
        public string Sender { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public string Platform { get; set; } = string.Empty; // WhatsApp, Telegram, etc.
    }
}
