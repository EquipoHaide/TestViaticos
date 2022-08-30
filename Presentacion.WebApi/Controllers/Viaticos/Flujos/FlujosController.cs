using System;
using Aplicacion.Nucleo;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.WebApi.Controllers.Viaticos
{
    public class FlujosController : ControllerBase
    {

        IAplicacion App { get; set; }

        public FlujosController(IAplicacion app)
        {
            App = app;
        }




    }
}
