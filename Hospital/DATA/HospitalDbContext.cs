using Hospital.MODELS;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DATA
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<CitaMedico> CitaMedico { get; set; }
        public DbSet<SignosVitales> SignosVitales { get; set; }
        public DbSet<Receta> Receta { get; set; }
        public DbSet<DetalleReceta> DetalleReceta { get; set; }
        public DbSet<CitaMedicaDiagnostico> CitaMedicaDiagnostico { get; set; }
        public DbSet<Diagnostico> Diagnostico { get; set; }
    }
}
