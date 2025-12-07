namespace FP_CSharp.Models
{
    public class Message
    {
        public string? Text { get; set; }

        public Message(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return $"Message: {Text}";
        }
    }
}