using System;
using System.Configuration;
using DataEntities;
using DataModelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PruebaConexion.Modelos
{
    public partial class MakersDBContext : DbContext, IMarkersDBContext
    {

        private IConfiguration Configuration { get; }

        
        public MakersDBContext()
        {
        }

        

        public MakersDBContext(DbContextOptions<MakersDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {

                //optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.Apellidos).HasMaxLength(100);

                entity.Property(e => e.Celular).HasMaxLength(30);

                entity.Property(e => e.DireccionEnvio).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Nombres).HasMaxLength(100);

                entity.Property(e => e.TelefonoFijo).HasMaxLength(30);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Compra_Cliente");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_Compra_Empleado");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.IdLibro)
                    .HasConstraintName("FK_Compra_Libro");
            });

            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(e => e.IdEditorial);

                entity.Property(e => e.Nombre).HasMaxLength(200);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.Apellidos).HasMaxLength(100);

                entity.Property(e => e.Cargo).HasMaxLength(30);

                entity.Property(e => e.Celular).HasMaxLength(30);

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Nombres).HasMaxLength(100);

                entity.Property(e => e.TelefonoFijo).HasMaxLength(30);
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.IdLibro);

                entity.Property(e => e.Autor).HasMaxLength(50);

                entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.PrecioSugerido).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titulo).HasMaxLength(200);

                entity.HasOne(d => d.IdEditorialNavigation)
                    .WithMany(p => p.Libro)
                    .HasForeignKey(d => d.IdEditorial)
                    .HasConstraintName("FK_Libro_Editorial");
            });
        }
    }
}
