using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vacation
{
    class VacationData
    {
        public List<(string name, DateTime start, DateTime finish)> VacationDates { get; private set; }

        public VacationData()
        {
            VacationDates = new();
        }

        public void AddVacation((string, DateTime, DateTime) vacation)
        {
            VacationDates.Add(vacation);
        }

        public double AverageVacationDuration()
        {
            return VacationDates.Average(x => (x.finish - x.start).Days);
        }

        public List<(string, double)> AverageEmployeeVacationDuration()
        {
            List<(string, double)> averageByEmployee = VacationDates.GroupBy(e => e.name)
                                                .Select(g => ((name: g.Key, Avg: g.Average(x => (x.finish - x.start).Days)))).ToList();
            return averageByEmployee;
        }
    }
}
