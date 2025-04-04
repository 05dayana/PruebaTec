using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTec.Models
{
    [Table("Clientes")]
    public class Clientes:Entidad
    {
        public enum tipo { nuevo, frecuente, muyfrecuente}
        public string nombre { get; set; }
        public string direccion { get; set; }
        public tipo tipocliente { get; set; }
        public List<Pedido> pedidos { get; set; }   

    }
}
