using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Abstrato2.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualInCome { get; set; }

        public TaxPayer()
        { 
        }

        public TaxPayer(string name, double anualInCome)
        {
            Name = name;
            this.AnualInCome = anualInCome;
        }

        public abstract double Tax();
    }
}
