namespace BookStoreApp;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "--test")
        {
            TestCases.RunAllTests();
            return;
        }

        try
        {
            string[] bookData = Console.ReadLine()!.Split(' ');
            string bookId = bookData[0];
            string title = bookData[1];
            int price = int.Parse(bookData[2]);
            int stock = int.Parse(bookData[3]);

            Book book = new Book(bookId, title, "Author", price, stock);
            BookUtility bookUtility = new BookUtility(book);

            while (true)
            {
                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        bookUtility.GetBookDetails();
                        break;

                    case 2:
                        int newPrice = int.Parse(Console.ReadLine()!);
                        bookUtility.UpdateBookPrice(newPrice);
                        break;

                    case 3:
                        int newStock = int.Parse(Console.ReadLine()!);
                        bookUtility.UpdateBookStock(newStock);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
        catch (InvalidBookDataException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
