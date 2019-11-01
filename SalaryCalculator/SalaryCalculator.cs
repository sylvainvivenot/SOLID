using System;
using System.Collections.Generic;

namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<EmployeeReport> employeeReports;

        public SalaryCalculator(List<EmployeeReport> employeeReports)
        {
            this.employeeReports = employeeReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var employeeReport in this.employeeReports)
            {
                if (employeeReport.Level == "Boss")
                {
                    totalSalaries += employeeReport.HourlyRate * employeeReport.WorkingHours * 1.2;
                }
                else
                {
                    totalSalaries += employeeReport.HourlyRate * employeeReport.WorkingHours;
                }
            }

            return totalSalaries;
        }
    }
}
