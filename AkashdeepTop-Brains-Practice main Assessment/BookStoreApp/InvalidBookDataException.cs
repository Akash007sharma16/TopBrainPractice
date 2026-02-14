namespace BookStoreApp;


public class InvalidBookDataException : Exception
{
    public InvalidBookDataException(string message) : base(message)
    {
    }

    public InvalidBookDataException(string message, Exception innerException) 
        : base(message, innerException)
    {
    }
}
