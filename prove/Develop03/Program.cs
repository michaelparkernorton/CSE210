using System;
using System.Text.Json;
using System.Text.Json.Serialization;


class Program
{
    static void Main(string[] args)
    {
        Purchase purchase = new Purchase{
            ProductName = "Orange Juice",
            DateTime = DateTime.UtcNow,
            ProductPrice = 2.49m,
        };

        Purchase purchase2 = new Purchase
        {
            ProductName = "Apple Juice",
            DateTime = DateTime.UtcNow,
            ProductPrice = 2.49m,
        };

        Order order = new Order();
        order.Purchases.Add(purchase);
        order.Purchases.Add(purchase2);
        //{
        //    Purchases = { purchase, purchase2 },
        //};

        string jsonString = JsonSerializer.Serialize(order.Purchases);
        Console.WriteLine(jsonString);
        Console.ReadLine();

        //string jsonString = JsonConvert.SerializeObject(order);
        //File.WriteAllText("order.json", jsonString);


        //purchase.saveFile();
    }
}