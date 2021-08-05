using System;
using System.Collections.Generic;
using System.Text;

namespace Lepesh.SoftwareDevelop.Domain
{
    public static class Settings
    {
        /// <summary>
        /// Количество рабочих часов в месяце
        /// </summary>
        public const byte WorkHoursInMonth = 160;   // константа для расчета з/п для всех категорий работников 
        /// <summary>
        /// рабочие часы в день
        /// </summary>
        public const byte WorkHourInDay = 8;
    }
}
