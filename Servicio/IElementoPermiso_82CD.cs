using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public interface IElementoPermiso_82CD
    {
        string Nombre_82CD { get; set; }

        List<ServicioPermiso_82CD> ObtenerPermisos_82CD();
    }
}
