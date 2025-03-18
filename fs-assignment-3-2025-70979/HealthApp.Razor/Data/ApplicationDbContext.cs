using HealthApp.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace HealthApp.Razor.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorSchedule> DoctorSchedules { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

        
    }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Enforce 48-hour cancellation policy (Handled in business logic)
        modelBuilder.Entity<Appointment>()
            .Property(a => a.AppointmentDateTime)
            .IsRequired();
    }*/
}

