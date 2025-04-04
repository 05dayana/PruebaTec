using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTec.Models
{
    [Table("Pedido")]
    public class Pedido : Entidad
    {
        public DateTime fechapedido { get; set; }
        public long idcliente { get; set; }

        [ForeignKey("idcliente")]
        public Clientes clientes { get; set; }
        
        public List<Detalle_Pedido> detalle_Pedidos { get; set; }
    }
}
