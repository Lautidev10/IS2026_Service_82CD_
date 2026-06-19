using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ServicioFamilia_82CD : IElementoPermiso_82CD
    {
        public int IdFamilia_82CD { get; set; }
        public string Nombre_82CD { get; set; }

        private List<IElementoPermiso_82CD> elementos_82CD = new List<IElementoPermiso_82CD>();

        public List<IElementoPermiso_82CD> Elementos_82CD
        {
            get { return elementos_82CD; }
        }

        
        public void AgregarElemento_82CD(IElementoPermiso_82CD elemento_82CD)
        {
            elementos_82CD.Add(elemento_82CD);
        }

        public List<ServicioPermiso_82CD> permisosSeleccionados_82CD { get;set; } = new List <ServicioPermiso_82CD>();
        public List<ServicioFamilia_82CD> familiasSeleccionadas_82CD { get; set; } = new List<ServicioFamilia_82CD>();


        public List<ServicioPermiso_82CD> ObtenerPermisos_82CD()
        {
            List<ServicioPermiso_82CD> accesos_82CD = new List<ServicioPermiso_82CD>();

            foreach (IElementoPermiso_82CD elementosRelacionados_82CD in elementos_82CD)
            {
                List<ServicioPermiso_82CD> permisosDelElemento_82CD = elementosRelacionados_82CD.ObtenerPermisos_82CD();

                foreach (ServicioPermiso_82CD permiso_82CD in permisosDelElemento_82CD)
                {
                    accesos_82CD.Add(permiso_82CD);
                }
            }
            return accesos_82CD;
        }


    }
}
