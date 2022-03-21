using System.Collections.Generic;
using System;
using System.Linq;

namespace ProductSaleWebApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Category> Pieces { get; set; } = new List<Category>();

        public Category()
        {
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddPiece()
        {

        }

    }
}
