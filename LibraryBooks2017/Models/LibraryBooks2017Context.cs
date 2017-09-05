using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryBooks2017.Models
{ 

    public class LibraryBooks2017Context : DbContext
    {
        public LibraryBooks2017Context()
            : base("name=LibraryBooksContext2")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        //  public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(A => A.Books)
                .WithRequired(A => A.Author)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Book>()
                .HasMany(B => B.Reviews)
                .WithRequired(B => B.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(G => G.Books)
                .WithRequired(G => G.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(U => U.Gender)
                .IsFixedLength();

        }
    }
}