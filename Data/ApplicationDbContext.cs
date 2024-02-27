using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TNews.Models;

namespace TNews.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Noticia>()
                //.ToTable("Noticia")
                .HasKey(n => n.Id);

            modelBuilder.Entity<Categoria>()
                //.ToTable("Categorias")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Autor>()
                //.ToTable("Autores")
                .HasKey(a => a.Id);

            // Relações

            modelBuilder.Entity<Noticia>()
                .HasOne(n => n.Autor)
                .WithMany(a => a.Noticias)
                .HasForeignKey(n => n.AutorId);

            modelBuilder.Entity<Noticia>()
                .HasOne(n => n.Categoria)
                .WithMany(c => c.Noticias)
                .HasForeignKey(n => n.CategoriaId);
        }
    }
}


