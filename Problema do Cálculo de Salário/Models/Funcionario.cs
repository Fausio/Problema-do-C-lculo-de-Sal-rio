using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_do_Cálculo_de_Salário.Models
{

    public enum Cargo
    {
        DESENVOLVEDOR,
        DBA,
        TESTADOR
    }

    class Funcionario
    {
        public String Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Funcionario(String nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }
    }
}
//• Desenvolvedores possuem 20% de desconto caso seu salário sejamaior do que
//R$ 3000,0. Caso contrário, o desconto é de 10%.
//• DBAs e testadores possuem desconto de 25% se seus salários forem maiores
//do que R$ 2500,0. 15%, em caso contrário.