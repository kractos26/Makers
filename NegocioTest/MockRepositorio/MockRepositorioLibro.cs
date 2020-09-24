using DataEntities;
using Moq;
using NegocioTest.Stups;
using Repositorio;

namespace NegocioTest.MockRepositorio
{
    public class MockRepositorioLibro
    {
        public Mock<ILibroRepository> _bllibrorepository { get; set; }

        public MockRepositorioLibro()
        {
            _bllibrorepository = new Mock<ILibroRepository>();
        }

        private void Setup()
        {
            _bllibrorepository.Setup(x => x.Adicionar(It.IsAny<Libro>())).Returns(LibroStup.dtoLibro);
            _bllibrorepository.Setup(x => x.Buscar(y => y.IdEditorial == 1)).Returns(LibroStup.list);
            _bllibrorepository.Setup(x => x.Modificar(It.IsAny<Libro>())).Returns(LibroStup.dtoLibro);
            _bllibrorepository.Setup(x => x.GetAll()).Returns(LibroStup.list);
            _bllibrorepository.Setup(x => x.TraerUno(y => y.IdLibro == 1)).Returns(LibroStup.dtoLibro);


        }
    }
}
