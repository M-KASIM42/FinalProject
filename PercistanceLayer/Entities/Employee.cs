using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercistanceLayer.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Concat(FirstName + " " + LastName);
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime OnCreatedDate { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }

    }
}
