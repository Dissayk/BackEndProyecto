using System.ComponentModel.DataAnnotations;

namespace BackEndProyecto.Model
{
    public class Supplier
    {
        [Key]
        public int IdSupplier { get; set; }
        public string Name { get; set; }
        public int Nit { get; set; }
        public string Service { get; set; }

    }
}
