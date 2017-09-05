namespace LibraryBooks2017.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;


    public partial class User
    {
        public string UseId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Birthdate { get; set; }

        [DataType(DataType.ImageUrl)]
        public byte[] Picture { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Address { get; set; }


        [StringLength(10)]
        public string ZipeCode { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Info { get; set; }

        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }



    }
}