using CursoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CursoDDD.DataAccess.EntitiesMappings
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.cnpj)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("Empresa");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cnpj).HasColumnName("cnpj");
            this.Property(t => t.dataCadastro).HasColumnName("dataCadastro");
            this.Property(t => t.ativo).HasColumnName("ativo");
        }
    }
}