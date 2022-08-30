using System;
using Infraestructura.Transversal.Plataforma;

namespace Aplicacion.Viaticos.Servicios
{
    public interface IServicioSolicitudes
    {

        Respuesta<ConsultaPaginada<int/*Modelos.Perfil*/>> ConsultarSolicitudes(/*ConsultaPerfil filtro, string subjectId*/);
    }
}
