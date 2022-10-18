using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SuperMarketManagement.Models
{
    public partial class SuperMarketSystemContext : DbContext
    {

        public SuperMarketSystemContext()
        {
        }

        public SuperMarketSystemContext(DbContextOptions<SuperMarketSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Subcategory> Subcategory { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:sty1001-classproject.database.windows.net,1433;Initial Catalog=cambriancoffeeshop;Persist Security Info=False;User ID=dbuser;Password=Cambrian@2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.ToTable("subcategory");

                entity.Property(e => e.subcategoryId).HasColumnName("subcategoryId");


                entity.Property(e => e.subCategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subcategoryName");

                entity.Property(e => e.subcategoryPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("subcategoryPrice");

                entity.Property(e => e.subCategoryImage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subcategoryImage");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
}
