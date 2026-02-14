using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public int Id;
    public string Name = "";
    public double Price;
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product{ Id = 1, Name = "Pen", Price = 10 },
            new Product{ Id = 2, Name = "Notebook", Price = 50 }
        };

        StringBuilder sb = new StringBuilder();

        sb += "Id,Name,Price\n";

        foreach (var p in products)
            sb += p.Id + "," + p.Name + "," + p.Price + "\n";

        Console.WriteLine(sb.ToString());
    }
}
