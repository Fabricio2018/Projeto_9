using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Composicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } /*data do contrato*/
        public double ValuePerHour { get; set; } /*valor por hora do contrato*/
        public int Hours { get; set; } /*Duração em horas do contrato*/
        public HourContract()
        {

        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue() /*Retornar o valor total do contrato*/
        {
            return Hours * ValuePerHour;
        }
    }
}
