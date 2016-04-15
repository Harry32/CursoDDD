using CursoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CursoDDD.DataAccess.EntitiesMappings
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.cpf)
                .IsRequired()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("Funcionario");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idEmpresa).HasColumnName("idEmpresa");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cpf).HasColumnName("cpf");
            this.Property(t => t.salario).HasColumnName("salario");
            this.Property(t => t.dataCadastro).HasColumnName("dataCadastro");
            this.Property(t => t.ativo).HasColumnName("ativo");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Funcionarios)
                .HasForeignKey(d => d.idEmpresa);

        }
    }
}