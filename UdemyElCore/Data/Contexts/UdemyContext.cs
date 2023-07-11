using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using UdemyElCore.Data.Entities;

namespace UdemyElCore.Data.Contexts
{
    public class UdemyContext :DbContext
    {
        internal object Product;

        public UdemyContext(object product)
        {
            Product = product;
        }



        private Action<TableBuilder> schema;

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("database=udemyEfCore;" +
                "integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(x =>x.Number);

            //birden fazla alana primary key verirsek
            //// modelBuilder.Entity<Customer>().HasKey(c => new {c.number,x.name});
            ///
            // modelBuilder.Entity<Customer>().HasNoKey();

            //modelBuilder.Entity<Category>().ToTable(name: "Categories", schema"dbo");

            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired(true);
            modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("'ürün bilgisi" +
                "girişmemiş'");
            modelBuilder.Entity<Product>().Property(X => X.CreatedTime).HasDefaultValueSql("getdate()");



            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("product_Id");

            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName("product_Price");
            modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18,3);

            base.OnModelCreating(modelBuilder);
        }
    }
}
