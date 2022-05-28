using System.ComponentModel.DataAnnotations;

namespace BackEndProyecto.Model
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public string DistributionChannel { get; set; }
    }
}
