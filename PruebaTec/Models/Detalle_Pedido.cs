using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTec.Models
{
    [Table("Detalle_pedido")]
    public class Detalle_Pedido:Entidad
    {
        [Column("idpedido")]
        public long idpedido { get; set; }
        [ForeignKey("idpedido")]
        public Pedido pedido { get; set; }

        [Column("idproducto")]
        public long idproducto { get; set; }

        [ForeignKey("idproducto")]
        public Productos producto { get; set; }
        public int cantidad { get; set; }

    }
}
