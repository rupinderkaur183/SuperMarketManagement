using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SuperMarketManagement.Models
{
    public partial class cambrainsmms1Context : DbContext
    {
        public cambrainsmms1Context()
        {
        }

        public cambrainsmms1Context(DbContextOptions<cambrainsmms1Context> options)
            : base(options)
        {
        }
        public virtual DbSet<Subcategory> Subcategory { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:cambrian-smms1.database.windows.net,1433;Initial Catalog=cambrain-smms1;Persist Security Info=False;User ID=cambrian-smms1;Password=Qwer@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.ToTable("subcategory");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategoryid");


                entity.Property(e => e.SubcategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subcategoryname");

                entity.Property(e => e.SubcategoryPrice).HasColumnName("price");
                entity.Property(e => e.SubcategoryImage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subcategoryimage");

                entity.Property(e => e.SubcategoryQty).HasColumnName("qty");
            });


        OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
