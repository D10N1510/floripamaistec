using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PizzariaS09.Models;

public partial class PizzariaContexto : DbContext
{
    public PizzariaContexto()
    {
    }

    public PizzariaContexto(DbContextOptions<PizzariaContexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Borda> Bordas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PLEHEET\\SQLEXPRESS;User ID=sa;Password=1234;Database=PIZZARIAS09;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bordas__3213E83FB9359849");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estado__3213E83FB4515293");

            entity.ToTable("Estado");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Massas__3213E83F4E260580");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedidos__3213E83FDB559404");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPizza).HasColumnName("id_pizza");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdPizza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pizza");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_status");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3213E83F1D605BB1");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdBordas).HasColumnName("id_bordas");
            entity.Property(e => e.IdMassas).HasColumnName("id_massas");

            entity.HasOne(d => d.IdBordasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdBordas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_borda");

            entity.HasOne(d => d.IdMassasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdMassas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_massas");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PizzaSab__3213E83FDEFFDD9F");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPizzas).HasColumnName("id_pizzas");
            entity.Property(e => e.IdSabores).HasColumnName("id_sabores");

            entity.HasOne(d => d.IdPizzasNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdPizzas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pizzas");

            entity.HasOne(d => d.IdSaboresNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdSabores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sabor");
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sabores__3213E83FFEBA9A36");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sabor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sabor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
