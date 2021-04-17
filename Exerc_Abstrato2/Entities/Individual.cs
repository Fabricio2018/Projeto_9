using System;
using System.Collections.Generic;
using System.Text;
using Exerc_Abstrato2.Entities;

namespace Exerc_Abstrato2.Entities
{
    class Individual : TaxPayer
    {
        public double  healthExpenditures { get; set; }

        public Individual()
        { 
        }

        public Individual(string name, double anualInCome , double healthExpenditures)
            : base(name, anualInCome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualInCome < 20000.0)
            {
                return AnualInCome * 0.15 - healthExpenditures * 0.5;
            }

            else 
            {
                return AnualInCome * 0.25 - healthExpenditures * 0.5;
            }
        }
    }
}
