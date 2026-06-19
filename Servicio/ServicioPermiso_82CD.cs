using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ServicioPermiso_82CD : IElementoPermiso_82CD
    {

        public int IdPermiso_82CD { get; set; }
        public string Nombre_82CD { get; set; }
        public string Descripcion_82CD { get; set; }


        public List<ServicioPermiso_82CD> ObtenerPermisos_82CD()
        {
            List<ServicioPermiso_82CD> accesos_82CD = new List<ServicioPermiso_82CD>();
            accesos_82CD.Add(this);
            return accesos_82CD;
        }

    }
}
