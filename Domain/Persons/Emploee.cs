using System;
using System.Collections.Generic;
using System.Text;

namespace Lepesh.SoftwareDevelop.Domain.Persons
{
    public class Emploee: Staff
    {
        public Emploee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)    // передача конструктора в базовый конструктор Staff
        {

        }
    }
}
