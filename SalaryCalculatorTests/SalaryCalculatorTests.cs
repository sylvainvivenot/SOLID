using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SalaryCalculator;

namespace SalaryCalculatorTest
{
    public class SalaryCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_calculate_salary_without_bonus_When_only_employee()
        {
            SalaryCalculator.SalaryCalculator salaryCalculator = new SalaryCalculator.SalaryCalculator(new List<EmployeeReport>()
            {
                new EmployeeReport()
                {
                    Name = "Toto",
                    HourlyRate = 25,
                    Id = 1,
                    Level = "Employee",
                    WorkingHours = 40
                }
            });
            double actual = salaryCalculator.CalculateTotalSalaries();
            Check.That(actual).IsEqualTo(1000);
        }

        [Test]
        public void Should_calculate_salary_without_bonus_When_only_boss()
        {
            SalaryCalculator.SalaryCalculator salaryCalculator = new SalaryCalculator.SalaryCalculator(new List<EmployeeReport>()
            {
                new EmployeeReport()
                {
                    Name = "Toto",
                    HourlyRate = 25,
                    Id = 1,
                    Level = "Boss",
                    WorkingHours = 40
                }
            });
            double actual = salaryCalculator.CalculateTotalSalaries();
            Check.That(actual).IsEqualTo(1200);
        }

        [Test]
        public void Should_calculate_salary_without_bonus_When_one_boss_and_one_employee()
        {
            SalaryCalculator.SalaryCalculator salaryCalculator = new SalaryCalculator.SalaryCalculator(new List<EmployeeReport>()
            {
                new EmployeeReport()
                {
                    Name = "Toto",
                    HourlyRate = 25,
                    Id = 1,
                    Level = "Boss",
                    WorkingHours = 40
                },
                new EmployeeReport()
                {
                    Name = "Titi",
                    HourlyRate = 25,
                    Id = 1,
                    Level = "Employee",
                    WorkingHours = 40
                }
            });
            double actual = salaryCalculator.CalculateTotalSalaries();
            Check.That(actual).IsEqualTo(2200);
        }
    }
}