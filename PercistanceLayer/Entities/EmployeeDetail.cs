namespace PercistanceLayer.Entities
{
    public class EmployeeDetail
    {
        public int EmployeeDetailId { get; set; }
        public string Education { get; set; }
        public string Email { get; set; }
        public int Experience { get; set; }
        public string Occupation { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}
