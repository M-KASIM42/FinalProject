using CsvHelper;
using CsvHelper.Configuration;
using PercistanceLayer.DAL.EfCore;
using PercistanceLayer.Entities;
using System;
using System.Globalization;
using System.IO;

namespace CsvImporter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _employeeDal = new EfEmployeeDal();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine
            };
            using (var reader = new StreamReader(Path.Combine("C:\\sqlite3\\sample.csv")))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Records>();
                foreach (var item in records)
                {
                    var employee = new Employee();
                    employee.FirstName = item.FirstName;
                    employee.LastName = item.LastName;
                    employee.Gender = item.Gender;
                    employee.Age = item.Age;
                    employee.EmployeeDetail = new EmployeeDetail
                    {
                        Education = item.Education,
                        Email = item.Email,
                        Occupation = item.Occupation,
                        Experience = item.Experience,
                        Phone = item.Phone,
                        Salary = item.Salary
                    };
                    _employeeDal.Add(employee);
                }
            }
            Console.ReadLine();
        }
    }
}
