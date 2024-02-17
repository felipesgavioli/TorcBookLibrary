using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace TorcBookLibrary.Model
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("book_id")]
        public int BookId { get; set; }

        [Required]
        [Column("title", TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Required]
        [Column("first_name", TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name", TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Column("total_copies")]
        public int TotalCopies { get; set; }

        [Column("copies_in_use")]
        public int CopiesInUse { get; set; }

        [Column("type", TypeName = "varchar(50)")]
        public string Type { get; set; }

        [Column("isbn", TypeName = "varchar(80)")]
        public string ISBN { get; set; }

        [Column("category", TypeName = "varchar(50)")]
        public string Category { get; set; }
    }
}