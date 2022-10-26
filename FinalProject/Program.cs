using DomainLayer.Service;
using System;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new EmployeeService();
            service.GetAll().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
            Console.ReadKey();
        }
    }
}
