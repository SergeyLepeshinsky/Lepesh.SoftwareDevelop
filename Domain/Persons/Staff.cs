using System;
using System.Collections.Generic;
using System.Text;

namespace Lepesh.SoftwareDevelop.Domain
{
    public class Staff: Person
    {
        public decimal MonthSalary { get; }     // месячная з/п
        public Staff(string name, decimal monthSalary, List<TimeRecord> timeRecords) : base(name, timeRecords)    // передача конструктора в базовый конструктор Person
        {
            MonthSalary = monthSalary;
        }
    }
}
