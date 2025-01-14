using System;
using System.Collections.Generic;
using System.IO;

class Shop
{
    private List<string> products;

    public Shop()
    {
        products = new List<string>();

        if (File.Exists("projekt.txt"))
        {
            string content = File.ReadAllText("projekt.txt");
            if (!string.IsNullOrEmpty(content))
            {
                products.AddRange(content.Split(','));
                if (products[^1] == "")
                {
                    products.RemoveAt(products.Count - 1);
                }
            }
        }
        else
        {
            using (FileStream fs = File.Create("projekt.txt"));
        }
    }

    public void AddProduct(string productName)
    {
        if (!string.IsNullOrWhiteSpace(productName))
        {
            if (!products.Contains(productName))
            {
                products.Add(productName);
                products.Add("1");
                Console.WriteLine($"'{productName}' has been added to the shop.");
            }
            else
            {
                int index = products.IndexOf(productName);
                int quantity = int.Parse(products[index + 1]);
                products[index + 1] = (quantity + 1).ToString();
                Console.WriteLine($"'{productName}' has been added to the shop.");
            }
        }
        else
        {
            Console.WriteLine("Product name cannot be empty.");
        }
    }

    public void RemoveProduct(string productName)
    {
        if (products.Contains(productName))
        {
            int index = products.IndexOf(productName);
            int quantity = int.Parse(products[index + 1]);

            if (quantity == 1)
            {
                products.RemoveAt(index + 1);
                products.RemoveAt(index);
            }
            else
            {
                products[index + 1] = (quantity - 1).ToString();
            }
        }
    }

    public void ShowProducts()
    {
        if (products.Count > 0)
        {
            Console.WriteLine("Products in the shop:");
            for (int i = 0; i < products.Count; i += 2)
            {
                Console.WriteLine($"{products[i]}: {products[i + 1]}");
            }
        }
        else
        {
            Console.WriteLine("No products in the shop yet.");
        }
    }

    public void Save()
    {
        File.WriteAllText("projekt.txt", string.Join(",", products));
        Console.WriteLine("Products saved successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();
        Console.WriteLine("Welcome to the Shop Management System!");

        string password = "";
        while (password != "haslo")
        {
            Console.Write("Please type your username: ");
            Console.ReadLine();

            Console.Write("Please type your password: ");
            password = Console.ReadLine();

            if (password != "haslo")
            {
                Console.WriteLine("Password incorrect, please try again.");
            }
        }

        Console.WriteLine("Login successful.");

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. Remove a product");
            Console.WriteLine("3. Show products");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1/2/3/4/5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the product name: ");
                    string addProductName = Console.ReadLine();
                    shop.AddProduct(addProductName);
                    break;

                case "2":
                    Console.Write("Enter the product name: ");
                    string removeProductName = Console.ReadLine();
                    shop.RemoveProduct(removeProductName);
                    break;

                case "3":
                    shop.ShowProducts();
                    break;

                case "4":
                    shop.Save();
                    break;

                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
