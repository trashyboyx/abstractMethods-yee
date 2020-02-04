using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace abstractMethods_yee.Entities
{
    class IndividualPerson : Person
    {
        public double GastoSaude { get; set; }

        public IndividualPerson(string nome, double renda, double gastoSaude) : base(nome, renda)
        {
            GastoSaude = gastoSaude;
        }

        public override double ImpostoAnual()
        {
            double imposto = Renda < 20000 ? Renda * 0.15 : Renda * 0.25;
            imposto = GastoSaude > 0 ? imposto - (GastoSaude * 0.5) : imposto;
            return imposto;
        }

    }
}
