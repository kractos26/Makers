using System;
using System.Collections.Generic;

namespace DataEntities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Compra = new HashSet<Compra>();
        }

        public int IdCliente { get; set; }
        public int? Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DireccionEnvio { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
    }
}
