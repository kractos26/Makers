using System;
using System.Collections.Generic;

namespace DataEntities
{
    public partial class Compra
    {
        public int IdCompra { get; set; }
        public int? IdLibro { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Valor { get; set; }
        public int? IdEmpleado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Libro IdLibroNavigation { get; set; }
    }
}
