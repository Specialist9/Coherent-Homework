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
            var avgByEmpl = VacationDates.Where(x => (x.finish - x.start).Days > 1)
                                .GroupBy(vac => vac.start.Month)
                                .Select(c => new Tuple<int, int>(c.Key, c.Count()))
                                .ToList();

            foreach (var element in avgByEmpl)
            {
                Console.WriteLine($"Month {element.Item1} - Number of employees on vacation: {element.Item2}");
            }
        }

        public List<DateTime> FreeDays()
        {
            DateTime yearStart = new(2021, 01, 01);
            DateTime yearEnd = new(2021, 12, 31);
            
            List<DateTime> Year2021 = new();

            for (DateTime date = yearStart; date <= yearEnd; date = date.AddDays(1))
            {
                Year2021.Add(date);
            }

            List<DateTime> VacDates = new();

            foreach (var element in VacationDates)
            {
                for (DateTime date = element.Item2; date <= element.Item3; date = date.AddDays(1))
                {
                    if (!VacDates.Contains(date))
                    {
                        VacDates.Add(date);
                    }
                }
            }

            var DaysFree = Year2021.Except(VacDates);

            return DaysFree as List<DateTime>;
        }

        public void CheckForDataCorrectness()
        {

        }
    }
}
