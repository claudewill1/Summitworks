using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Summitworks_Project.Models
{
    
    public class Book
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string BookName { get; set; }
        [MaxLength(25)]
        public string BookAuthor { get; set; }
        //[Required]
        //[Column(Order = 1)]
        //public double Price { get; set; }
        [Required]
        public Category? BookCategory { get; set; }
        //public int AuthorID { get; set; }
        //public Author Author { get; set; }
    }
}
