using DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class SaremChapContext : DbContext, IUnitOfWork
    {
        public SaremChapContext()
            : base("SaremChapContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Value>()
    .HasRequired(d => d.Form)
    .WithMany()
    .HasForeignKey(d => d.FormId)
    .WillCascadeOnDelete(false);
            modelBuilder.Entity<Form>()
    .HasRequired(u => u.Product)
    .WithMany()
    .HasForeignKey(u => u.ProductId);



        }


        public DbSet<Chapter> Chapters { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Field> Fields { set; get; }
        public DbSet<Form> Forms { set; get; }
        public DbSet<Gallery> Galleries { set; get; }
        public DbSet<GalleryItem> GalleryItems { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<Price> Pricis { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<Subject> Subjects { set; get; }
        public DbSet<Value> Values { set; get; }


        #region IUnitOfWork Members
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        #endregion
    }
}
