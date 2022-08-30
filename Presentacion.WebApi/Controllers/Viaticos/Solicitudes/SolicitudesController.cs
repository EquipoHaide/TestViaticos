using System;
using Aplicacion.Nucleo;
using Aplicacion.Viaticos.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.WebApi.Controllers.Viaticos
{
    public class SolicitudesController : ControllerBase
    {
        IAplicacion App { get; set; }

        IServicioSolicitudes servicio;
        IServicioSolicitudes Servicio => App.Inject(ref servicio);

        public SolicitudesController(IAplicacion app) 
        {
            App = app; 

        }

        [HttpGet(Name = "ConsultarUsuarios")]
        public object Consultar(/*[FromQuery] ConsultarUsuariosModelo filtro*/)
        {
            try
            {
                var consulta = Servicio.ConsultarSolicitudes();

                //if (consulta.EsError)
                //{
                //    if (consulta.Estado == EstadoProceso.Fatal)
                //        return this.ApiResult(consulta.ExcepcionInterna, App.GetLogger());

                //    return this.ApiResult(consulta.Mensaje);
                //}

                //return this.ApiResult(consulta.Contenido);
                return this.ApiResult(App.GetLogger());

            }
            catch (Exception e)
            {
                return this.ApiResult(e, App.GetLogger());
            }
        }

    }
}
