using Microsoft.EntityFrameworkCore;
using static PruebaTec.Controllers.CategoriasController;

namespace PruebaTec.Models
{
    public class dbcontext:DbContext
    {
        protected readonly IConfiguration configuration;
        public dbcontext (IConfiguration configuration)
        {
            this.configuration = configuration; 
        }
        protected override void OnConfiguring (DbContextOptionsBuilder option)
        {
            option.UseSqlServer(configuration.GetConnectionString("conexion"));
        
        }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<graficoViewModel> grafico { get; set; }
        public virtual DbSet<Productos> productos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Detalle_Pedido> Detalle_Pedidos { get; set; }

        //Marcar la clase como sin llave enenOnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<graficoViewModel>().HasNoKey();
        }


    }
}
