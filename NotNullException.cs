namespace Exception_Constructors
{
    public class NotNullException : Exception
    {
      const string message = "Input is null !!!";

        public NotNullException() : base(message)
        { }
        public NotNullException(string infoMessage, Exception innerException) : base(String.Format($"{message}, {infoMessage}.", innerException))
        { }
    }
}
