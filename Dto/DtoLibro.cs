using System;
using System.Collections.Generic;

namespace Dto
{
    public class DtoLibro
    {
        public int? IdLibro { get; set; }
        public string Titulo { get; set; }
        public int? IdEditorial { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Costo { get; set; }
        public decimal? PrecioSugerido { get; set; }
        public string Autor { get; set; }

        public virtual List<DtoCompra> Compra { get; set; }
        public virtual DtoEditorial DtoEditorial { get; set; }
    }
}
