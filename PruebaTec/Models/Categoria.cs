using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTec.Models
{
    [Table("Categoria")]
    public class Categoria: Entidad
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        [NotMapped]
        public List <Productos>? productos { get; set; }

    }
}
