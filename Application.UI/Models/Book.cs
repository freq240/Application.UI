using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
