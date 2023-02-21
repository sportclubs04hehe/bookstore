﻿using System.ComponentModel.DataAnnotations;

namespace bookstoreweb.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorBio { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
