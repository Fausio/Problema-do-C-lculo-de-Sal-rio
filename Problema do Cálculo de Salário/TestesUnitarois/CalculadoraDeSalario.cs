using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problema_do_Cálculo_de_Salário.Models;

namespace Problema_do_Cálculo_de_Salário.TestesUnitarois
{
    [TestFixture]
    class CalculadoraDeSalario
    {

        private double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.9;
            }
            return funcionario.Salario * 0.9;
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();

            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DESENVOLVEDOR);
            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }


        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }


        [Test]
        public void deveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Mauricio", 500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);
            Assert.AreEqual(500.0 * 0.85, salario, 0.00001);
        }
    }
}
