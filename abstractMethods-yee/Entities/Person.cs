using System;
using System.Collections.Generic;
using System.Text;

namespace abstractMethods_yee.Entities
{
    abstract class Person
    {
        public string Nome { get; set; }
        public double Renda { get; set; }

        public Person(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }
        public abstract double ImpostoAnual();
    }
}
