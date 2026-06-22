using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermiso_82CD
    {
        private MapperPermiso_82CD mapperPermiso_82CD = new MapperPermiso_82CD();

        public List<ServicioPermiso_82CD> ListarPermisos_82CD()
        {
            return mapperPermiso_82CD.ListarPermisos_82CD();
        }

    }

}
