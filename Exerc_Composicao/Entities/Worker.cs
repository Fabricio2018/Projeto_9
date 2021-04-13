using Exerc_Composicao.Entities.Enums;
using System.Collections.Generic;

namespace Exerc_Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double  BasicSalary { get; set; }
        public Departement departement { get; set; }/*Associação de duas classes diferentes*/
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
            
        }
        public Worker(string name, WorkerLevel level, double basicSalary, Departement departement)
        {
            Name = name;
            Level = level;
            BasicSalary = basicSalary;
            this.departement = departement;
        }

        public void AddContracts(HourContract contract)/*Adicionar varios contratos que chegou no método*/
        {
            Contracts.Add(contract);
        }
        public void RemoveContracts(HourContract contract)/*Remover varios contratos que chegou no método*/
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)/*Quanto que o funcionario ganhou em uma certa data*/
        {
            double sum = BasicSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); /*Operação que vai retornar o valor do contrato*/
                }
            }
            return sum;
        }
    }
}
