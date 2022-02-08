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
                                                .Select(g => ((Name: g.Key, Avg: g.Average(x => (x.finish - x.start).Days)))).ToList();
            return averageByEmployee;
        }

        public void EmployeesOnVacationByMonth()
        {
            var avgByEmpl = VacationDates.GroupBy(vac => vac.start.Month)
                                .Select(g => new { Month = g.Key, EmployeesOnVaction = g.Count() })
                                .AsEnumerable()
                                .Select(c => new Tuple<int, int>(c.Month, c.EmployeesOnVaction))
                                .ToList();

            foreach (var element in avgByEmpl)
            {
                Console.WriteLine($"Month {element.Item1} - Number of employees on vacation: {element.Item2}");
            }
        }
    }
}
