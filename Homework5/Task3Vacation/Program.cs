using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            VacationData CompanyXVacations = new();

            CompanyXVacations.AddVacation(("John Deere", new(2021, 01, 10), new(2021, 01, 21)));
            CompanyXVacations.AddVacation(("Johnny Walker", new(2021, 01, 15), new(2021, 01, 31)));
            CompanyXVacations.AddVacation(("Dan Brown", new(2021, 02, 20), new(2021, 02, 28)));
            CompanyXVacations.AddVacation(("Bruce Wayne", new(2021, 03, 01), new(2021, 03, 15)));
            CompanyXVacations.AddVacation(("Clark Kent", new(2021, 03, 10), new(2021, 03, 25)));
            CompanyXVacations.AddVacation(("Clark Kent", new(2021, 06, 01), new(2021, 06, 15)));
            CompanyXVacations.AddVacation(("Bruce Wayne", new(2021, 07, 01), new(2021, 07, 10)));
            Console.WriteLine("//////////////////");


            foreach (var vac in CompanyXVacations.VacationDates)
            {
                Console.WriteLine($"Employee: {vac.name}, Vacation duration: {(vac.finish - vac.start).Days}");
            }
            Console.WriteLine("//////////////////");


            double averageVacDuration = CompanyXVacations.VacationDates.Average(x => (x.finish - x.start).Days);
            Console.WriteLine(averageVacDuration);

            var tesList = CompanyXVacations.AverageEmployeeVacationDuration();
            foreach (var item in tesList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("//////////////////");


            CompanyXVacations.EmployeesOnVacationByMonth();

            CompanyXVacations.FreeDays();

        }
    }
}
