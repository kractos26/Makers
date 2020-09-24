using Data;
using Microsoft.Extensions.DependencyInjection;
using Negocio;
using Negocio.Interfaz;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transversal.Registrar
{
    public static class IocRegister
    {

        public static  IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterRepository(services);

            AddRegistrationNegocio(services);
            return services;
        }

        private static IServiceCollection AddRegisterRepository(IServiceCollection services)
        {
            services.AddTransient<ILibroRepository, LibroRepository>();
            return services;
        }

        private static IServiceCollection AddRegistrationNegocio(this IServiceCollection services)
        {
            services.AddScoped<IBLLibro, BLLibro>();

            return services;
        }
    }
}
