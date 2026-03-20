using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assignment1_Book
{
    internal class Books
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Books(int id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
