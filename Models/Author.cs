using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_80_EFCore01.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
