using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace chaknuul_services.Models;

public partial class DbAae570Chaknuul2024Context : DbContext
{
    public DbAae570Chaknuul2024Context()
    {
    }

    public DbAae570Chaknuul2024Context(DbContextOptions<DbAae570Chaknuul2024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<EventosV2> EventosV2s { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PseudoToken> PseudoTokens { get; set; }

    public virtual DbSet<Tipo> Tipos { get; set; }

    public virtual DbSet<UsuariosAdmin> UsuariosAdmins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql8011.site4now.net;Database=db_aae570_chaknuul2024;User Id=db_aae570_chaknuul2024_admin;Password=20200130Liam.");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Eventos__3214EC07BB288564");

            entity.Property(e => e.Actividades)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEdicion).HasColumnType("datetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Incluye)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Informacion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Itinerario)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Llamada)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Lugar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Objetivo)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Subtitulo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventosV2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventosV__3214EC07362D75C9");

            entity.ToTable("EventosV2");

            entity.Property(e => e.Contenido).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Lugar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubTitulo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Partners__3214EC07364F6E9F");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Equis)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Facebook)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Imagen)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Instagram)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Otros)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Otros2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Whatsapp)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Youtube)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PseudoToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PseudoTo__3214EC0704ABB6F9");

            entity.Property(e => e.Creacion).HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Vigencia).HasColumnType("datetime");
        });

        modelBuilder.Entity<Tipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tipos__3214EC07E38AEB05");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tipo1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo");
        });

        modelBuilder.Entity<UsuariosAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07D8E1F7BF");

            entity.ToTable("UsuariosAdmin");

            entity.Property(e => e.GuidActivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
