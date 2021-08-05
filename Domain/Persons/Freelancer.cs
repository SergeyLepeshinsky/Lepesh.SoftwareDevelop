using System;
using System.Collections.Generic;
using System.Text;

namespace Lepesh.SoftwareDevelop.Domain
{
    public class Freelancer: Person
    {
        public Freelancer(string name, List<TimeRecord> timeRecords) : base(name, timeRecords)    // передача конструктора в базовый конструктор Person
        {
            
        }
    }
}
