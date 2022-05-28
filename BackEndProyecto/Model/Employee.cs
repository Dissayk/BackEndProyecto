using System.ComponentModel.DataAnnotations;

namespace BackEndProyecto.Model
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

    }
}
