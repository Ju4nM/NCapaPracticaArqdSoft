using System;
using System.Collections.Generic;
using CRUDProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDProject.DAL.DataContext;

public partial class MvcpracticaArqdSoftContext : DbContext
{
    public MvcpracticaArqdSoftContext()
    {
    }

    public MvcpracticaArqdSoftContext(DbContextOptions<MvcpracticaArqdSoftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__Contact__5C66259BAE8FCBE8");

            entity.ToTable("Contact");

            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
