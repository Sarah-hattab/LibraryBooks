namespace LibraryBooks2017.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }

        [Required]
        [StringLength(128)]
        //DataType(DataType.EmailAddress)
        public string UserId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Text { get; set; }

        public Byte? Rating { get; set; }
        public DateTime Created { get; set; }
        public bool IsDelete { get; set; }


        public virtual Book Book { get; set; }

    }
}