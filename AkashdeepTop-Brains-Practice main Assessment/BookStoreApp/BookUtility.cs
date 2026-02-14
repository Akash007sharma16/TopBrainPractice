namespace BookStoreApp;

public class BookUtility
{
    private Book _book;

    public BookUtility(Book book)
    {
        _book = book;
    }

   
    public void GetBookDetails()
    {
        Console.WriteLine($"Details: {_book.Id} {_book.Title} {_book.Price} {_book.Stock}");
    }

   
    public void UpdateBookPrice(int newPrice)
    {
        _book.Price = newPrice;
        Console.WriteLine($"Updated Price: {newPrice}");
    }

    public void UpdateBookStock(int newStock)
    {
        _book.Stock = newStock;
        Console.WriteLine($"Updated Stock: {newStock}");
    }

    public void ApplyDiscount(double discountPercent)
    {
        if (discountPercent < 0 || discountPercent > 100)
            throw new InvalidBookDataException("Discount percentage must be between 0 and 100");

        int discountedPrice = (int)(_book.Price * (1 - discountPercent / 100));
        _book.Price = discountedPrice;
        Console.WriteLine($"Discount Applied: {discountPercent}% - New Price: {discountedPrice}");
    }
}
