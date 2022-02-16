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
                                .Select(g => new {Month = g.Key, EmpOnVacation = g.Select(e => e.name).Distinct().Count()})
                                .Select(c => new Tuple<int, int>(c.Month, c.EmpOnVacation))
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
            
            List<DateTime> year2021 = new();

            for (DateTime date = yearStart; date <= yearEnd; date = date.AddDays(1))
            {
                year2021.Add(date);
            }

            List<DateTime> vacDates = new();

            foreach (var element in VacationDates)
            {
                for (DateTime date = element.Item2; date <= element.Item3; date = date.AddDays(1))
                {
                    if (!vacDates.Contains(date))
                    {
                        vacDates.Add(date);
                    }
                }
            }

            var daysFree = year2021.Except(vacDates);

            return daysFree as List<DateTime>;
        }

        public bool Overlap()
        {
            return VacationDates.Any(r => VacationDates.Where(q => q != r) //take an element from VacationDates as r and return another element in Vacationdates as q, where q != r
                                                       .Any(q => q.name == r.name && q.finish >= r.start && q.start <= r.finish)); //
        }

        public int CountOverlap()
        {
            int overlap = 0;

            foreach(var empvac in VacationDates.GroupBy(g => g.name).Where(w => w.Count() > 1)) //Group vacation data by employee name, where number of vacations in group is > 1
            {
                var vacdates = VacationDates.Where(x => x.name == empvac.Key).ToList(); //for each of groups make a list of vacation data entries, where employee name corresponds to group key (Employee name)
                                                                                        //take just the vacations of one employee and put them to list vacdates

                for (int i = 0; i < vacdates.Count; i++) //count elements in vacdates and iterate through them
                {
                    for(int j = i+1; j < vacdates.Count; j++) // for every iterration of i start another iteration of element after i
                    {
                        if (vacdates[i].start <= vacdates[j].finish && vacdates[j].start <= vacdates[i].finish) //compare vacation dates in i and j for overlap
                        {
                            overlap++;
                        }
                    }
                }
            }

            return overlap;
        }
    }
}
