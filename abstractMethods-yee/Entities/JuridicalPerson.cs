using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace abstractMethods_yee.Entities
{
    class JuridicalPerson : Person
    {
        public int NumeroFuncionarios { get; set; }

        public JuridicalPerson(string nome, double renda, int numeroFuncionarios) : base(nome, renda)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoAnual()
        {
            double imposto = NumeroFuncionarios > 10 ? Renda * 0.14 : Renda * 0.16;
            return imposto;
        }

    }
}
