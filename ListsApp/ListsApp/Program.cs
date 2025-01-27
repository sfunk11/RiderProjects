﻿using System.Reflection;

namespace ListsApp;

class Program
{
    static void Main(string[] args)
    {
        List<string> colors = new List<string>();
        colors.Add("red");
        colors.Add("green");
        colors.Add("blue");
        colors.Add("red");

        Console.WriteLine("Current colors in the list:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        
        //Loop to look for all occurrences of "red"
        bool isDeletingSuccessful = colors.Remove("red");
        while (isDeletingSuccessful)
        {
            isDeletingSuccessful = colors.Remove("red");
        }
        
        // .Remove() removes first occurence only
        // colors.Remove("red");
        Console.WriteLine("Current colors in the list:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
    
        //Declare List and initializing at once

        // List<string> myList =
        // [
        //     "stuff1",
        //     "stuff2"
        // ];
        
        List<int> myList = new List<int> { 10, 2, 13,58, 14 };

        myList.Sort();
        foreach (int item in myList)
        {
            Console.Write(item + " ");
        }
        // .Any() checks the list to see if ANY element satisfies the predicate.  Returns bool
        bool hasTen = myList.Any(x => x == 10);

        if (hasTen)
        {
            Console.WriteLine(" \nTen is in myList.");
        }

        List <Product> productList= new List<Product>
        {
            new Product{Name ="Apple", Price = 10},
            new Product{Name ="Banana", Price = 20},
            new Product{Name ="Orange", Price = 30}
        };
        productList.Add(new Product{Name ="Berries", Price = 20});
        List<Product> cheapestProducts = productList.Where(p => p.Price < 30).OrderBy(p => p.Price).ToList();
        Console.WriteLine("Available products:");
        foreach (Product product in productList)
        {
            Console.WriteLine($"product name: {product.Name} product price: {product.Price}");
        }
        
        Console.WriteLine("Cheapest Products:");
        foreach (Product product in cheapestProducts)
        {
            Console.WriteLine($"product name: {product.Name} product price: {product.Price}");
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}