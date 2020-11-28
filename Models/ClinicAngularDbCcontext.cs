using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClinicAngular.Models
{
    public class ClinicAngularDbCcontext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Doc> Docs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Setting> Settings { get; set; }

        public ClinicAngularDbCcontext(DbContextOptions<ClinicAngularDbCcontext> options)
           : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=clinicangular.db");
    }
}
