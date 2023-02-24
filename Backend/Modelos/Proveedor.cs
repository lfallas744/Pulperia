using System.ComponentModel.DataAnnotations;

namespace Backend.Modelos
{
    public enum Estado
    {
        activo,
        inactivo
    }
    public class Proveedor : Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Estado Estado { get; set; }
        public virtual List<Producto> Productos{ get; set; }

        public Proveedor()
        {
        }

        public double Cotizar()
        {
            return 0.0;
        }
    }
}
