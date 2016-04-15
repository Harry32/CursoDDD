using System;

namespace CursoDDD.Domain.Entities
{
    public partial class Funcionario
    {
        public int id { get; set; }
        public int idEmpresa { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public decimal salario { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}