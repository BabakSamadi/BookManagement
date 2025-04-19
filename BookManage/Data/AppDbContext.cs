using BookManage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookManage.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) {
        
        
        
        
        
        }


        public DbSet<Users> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Categories> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Book> ()
                .HasOne(x => x.categories)
                .WithMany(x => x.books)
                .HasForeignKey(x => x.CategoriesId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Users>()
                .HasMany(x => x.Books)
                .WithOne(x => x.Users)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }


    }
}
