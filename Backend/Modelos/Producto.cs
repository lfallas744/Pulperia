using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor{ get; set; }

        [NotMapped]
        public string CodigoBarras { get; set; }
        [NotMapped]
        public string Imagen { get; set; }
    }
}
