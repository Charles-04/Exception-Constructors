namespace Exception_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SendMessage sendMessage = new();
            sendMessage.Messenger();
        }
    }
}