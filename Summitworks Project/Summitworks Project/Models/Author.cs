using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Summitworks_Project.Models
{
    [Table("AuthorTable")]
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        public string FName { get; set; }
        [MaxLength(25)]
        public string LName { get; set; }
        [NotMapped]
        public string FullName { get { return FName + " " + LName; } }
        public List<Book> Books { get; set; }
    }
}
