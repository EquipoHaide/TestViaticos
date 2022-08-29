﻿using Dominio.Nucleo;

namespace Dominio.Seguridad.Modelos
{
    public class Grupo : IModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
