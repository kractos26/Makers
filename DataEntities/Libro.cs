using System;
using System.Collections.Generic;

namespace DataEntities
{
    public partial class Libro
    {
        public Libro()
        {
            Compra = new HashSet<Compra>();
        }

        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public int? IdEditorial { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Costo { get; set; }
        public decimal? PrecioSugerido { get; set; }
        public string Autor { get; set; }

        public virtual Editorial IdEditorialNavigation { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
    }
}
