using System.Collections.Generic;

namespace Dto
{
    public class DtoEditorial
    {
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }

        public  List<DtoLibro> Libro { get; set; }
    }
}
