using System;
using System.Collections.Generic;
using System.Text;

namespace matala6part2
{
    internal class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Item(int code, string name, string description, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public Item(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
