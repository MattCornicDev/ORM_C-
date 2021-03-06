using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestEfCore.DataAccess.DataObjects
{
    public partial class formationsContext : DbContext
    {
        public formationsContext()
        {
        }

        public formationsContext(DbContextOptions<formationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Formation> Formation { get; set; }
        public virtual DbSet<Stagiaire> Stagiaire { get; set; }
        public object Formations { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=formations");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>(entity =>
            {
                entity.HasKey(e => e.IdFormation)
                    .HasName("PRIMARY");

                entity.ToTable("formation");

                entity.Property(e => e.IdFormation)
                    .HasColumnName("idFormation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NbStagiaires).HasColumnType("int(11)");

                entity.Property(e => e.Niveau)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Stagiaire>(entity =>
            {
                entity.HasKey(e => e.IdStagiaire)
                    .HasName("PRIMARY");

                entity.ToTable("stagiaire");

                entity.HasIndex(e => e.IdFormation)
                    .HasName("idStagiaire");

                entity.Property(e => e.IdStagiaire)
                    .HasColumnName("idStagiaire")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Age).HasColumnType("int(11)");

                entity.Property(e => e.IdFormation)
                    .HasColumnName("idFormation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
