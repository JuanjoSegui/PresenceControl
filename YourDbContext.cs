using Microsoft.EntityFrameworkCore;
using PresenceControl.Models;
using System;

public class YourDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Presence> Presences { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración adicional si es necesaria
    }
}