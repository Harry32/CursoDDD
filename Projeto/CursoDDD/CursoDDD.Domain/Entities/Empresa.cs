using System;
using System.Collections.Generic;

namespace CursoDDD.Domain.Entities
{
    public partial class Empresa
    {
        public Empresa()
        {
            this.Funcionarios = new List<Funcionario>();
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}