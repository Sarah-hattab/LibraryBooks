namespace LibraryBooks2017.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Reviews = new HashSet<Review>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string UserId { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(256)]
        public string AlternativeTitle { get; set; }

        public short? Part { get; set; }


        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ISBN { get; set; }

        public DateTime? PublidhDate { get; set; }

        [StringLength(512)]
        public string ImagePath { get; set; }
        public DateTime Created { get; set; }
        public bool IsDelete { get; set; }

        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
