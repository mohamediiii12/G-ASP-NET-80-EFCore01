using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_80_EFCore01.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
