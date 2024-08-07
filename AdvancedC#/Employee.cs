using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
    }

    public class Promotion
    {
        public static bool SalaryCriteria(Employee emp)
        {
            return emp.Salary < 10000;
        }

        public static bool ExperienceCriteria(Employee emp)
        {
            return emp.Experience > 5;
        }

        public static List<Employee> Promote(List<Employee> employees, Func<Employee, bool> promotionCriteria)
        {
            return employees.Where(promotionCriteria).ToList();
        }
    }

}
