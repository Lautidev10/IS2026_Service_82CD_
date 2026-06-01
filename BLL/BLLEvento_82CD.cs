using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Servicio;

namespace BLL
{
    public class BLLEvento_82CD
    {
        private DAL.MapperEvento_82CD mapperEvento_82CD = new DAL.MapperEvento_82CD();

        
        public void RegistrarEvento_82CD(string login_82CD, string evento_82CD, string modulo_82CD, int criticidad_82CD)
        {
            mapperEvento_82CD.RegistrarEvento_82CD( login_82CD, evento_82CD, modulo_82CD, criticidad_82CD);
        }

        public List<ServicioEvento_82CD> ListarEventos_82CD()
        {
            return mapperEvento_82CD.ListarEventos_82CD();
        }

        public List<ServicioEvento_82CD> ObtenerEventosUlt3Dias_82CD()
        {
            return mapperEvento_82CD.ObtenerEventosUlt3Dias_82CD();
        }

        public ServicioUsuario_82CD BuscarUsuarioEvento_82CD(string login_82CD)
        {
            return mapperEvento_82CD.BuscarUsuarioEvento_82CD(login_82CD);
        }

        public List<ServicioEvento_82CD> FiltrarEventos_82CD(string login_82CD, DateTime fechaInicial_82CD, DateTime fechaFinal_82CD, string evento_82CD, string modulo_82CD, int criticidad_82CD)
        {
            return mapperEvento_82CD.FiltrarEventos_82CD(login_82CD, fechaInicial_82CD, fechaFinal_82CD, evento_82CD, modulo_82CD, criticidad_82CD);
        }
    }

}
