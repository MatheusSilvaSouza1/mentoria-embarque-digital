using FluentValidation.Results;
using mentoria_embarque_digital.Models;
using Microsoft.EntityFrameworkCore;

namespace mentoria_embarque_digital.Infra;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<ValidationResult>();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
    }

    public virtual DbSet<Contact> Contacts => Set<Contact>();
}