


namespace Exception_Constructors
{
    internal class SendMessage
    {
		internal void Messenger() {
			try
			{
				Console.WriteLine("         Anonnymous Message      😉😉😜  \n\n");
				Console.WriteLine("Enter Phone Number");
				var phoneNumber = Console.ReadLine();
				FormatNumber(phoneNumber);
				Console.WriteLine("Enter message");
				var message = Console.ReadLine();
				NullValidator(message);
				Console.Clear();
				Console.WriteLine($"Message Sent to {phoneNumber} Successfully");
			}catch(NotNullException ex)
			{
					Console.WriteLine($"Message: {ex.Message}");
				   Messenger();
			}
			catch (Exception exception )
			{
				Console.WriteLine($"Message: {exception.Message}");
                Messenger();
            } }


		long FormatNumber(string number)
		{
			if (string.IsNullOrEmpty(number))
			{
                throw new NotNullException();
				
            }
			else
			{

                bool isFormatable = long.TryParse((number), out long FormatedNumber);
                if (!isFormatable)
                {
                    throw new Exception($"{number} is not a valid input");
                }
                else
                {
                    return FormatedNumber;
                }
            }
			
		}
		void NullValidator(string message)
		{
			
				if (string.IsNullOrEmpty(message))
				{
					Exception ex = new();
					throw new NotNullException("Message can't be empty", ex);
                   
                }
			
		}
    }
}
