using AutoMapper;
using DataEntities;
using Moq;
using NegocioTest.Stups;
using Repositorio;

namespace NegocioTest.Config
{
    public class MockAutomapper
    {
        public Mock<IMapper> _mapper { get; set; }

        public MockAutomapper()
        {
            _mapper = new Mock<IMapper>();
        }

        private void Setup()
        {
        }
    }
}
