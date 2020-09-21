using System;
using System.Collections.Generic;

namespace DataEntities
{
    public partial class Empleado
    {
        public Empleado()
        {
            Compra = new HashSet<Compra>();
        }

        public int IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
        public string Cargo { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
    }
}
