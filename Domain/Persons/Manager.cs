using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lepesh.SoftwareDevelop.Domain
{
    public class Manager: Staff
    {
        public decimal MonthBonus => 20000;
        public decimal TotalPay { get; }
        public Manager(string name, List<TimeRecord> timeRecords) : base(name, 200000, timeRecords)    // передача конструктора в базовый конструктор Staff
        {
            // подсчет суммы всех отработанных часов объекта Manager
            // 
            decimal payPerHour = MonthSalary / Settings.WorkHoursInMonth; // за час работы
            decimal totalPay = 0;
            decimal bonusPerDay = (MonthBonus / Settings.WorkHoursInMonth) * Settings.WorkHourInDay;    //  за час переработки 1000р
            foreach (var timeRecord in timeRecords)
            {
                if (timeRecord.Hours <= Settings.WorkHourInDay)   
                {
                    totalPay += timeRecord.Hours * payPerHour;
                }
                else    // если переработка
                {
                    totalPay += Settings.WorkHourInDay * payPerHour + bonusPerDay;
                }
            }
            TotalPay = totalPay;
            // аналог подсчета часоы через еще не известный мне Linq
            //totalHours = timeRecords.Sum(x => x.Hours);
            
        }
    }
}
