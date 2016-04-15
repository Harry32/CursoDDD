using CursoDDD.DataAccess.EntitiesMappings;
using CursoDDD.Domain.Entities;
using System.Data.Entity;

namespace CursoDDD.DataAccess.Contexts
{
    public partial class CursoDDDContext : DbContext
    {
        static CursoDDDContext()
        {
            Database.SetInitializer<CursoDDDContext>(null);
        }

        public CursoDDDContext()
            : base("Name=CursoDDDContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
        }
    }
}