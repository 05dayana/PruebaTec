using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTec.Models
{
    [Table("Productos")]
    public class Productos:Entidad
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public long idcat { get; set; }

        [ForeignKey ("idcat")]
        public Categoria categoria { get; set; }

    }
}
