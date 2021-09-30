using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UI.Models
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public BookViewModel(string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}
