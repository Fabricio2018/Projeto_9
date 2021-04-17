using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Abstrato2.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company()
        { 
        }

        public Company(string name, double anualInCome, int numberOfEmployee)
            : base(name, anualInCome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double Tax()
        {
            if (NumberOfEmployee > 10)
            {
                return AnualInCome * 0.14;
            }

            else
            {
                return AnualInCome * 0.16;
            }
        }
    }
}
