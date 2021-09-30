using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UI.Models
{
    public class BookWithIdViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public BookWithIdViewModel(string id, string name, string price)
        {
            Id = id;    
            Name = name;
            Price = price;
        }
    }
}
