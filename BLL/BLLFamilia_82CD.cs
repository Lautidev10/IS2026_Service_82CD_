using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFamilia_82CD
    {
        private MapperFamilia_82CD mapperFamilia_82CD = new MapperFamilia_82CD();
        private BLLEvento_82CD bllEvento_82CD = new BLLEvento_82CD();


        public List<ServicioFamilia_82CD> ListarFamilias_82CD()
        {
            return mapperFamilia_82CD.ListarFamilias_82CD();
        }


        public ServicioFamilia_82CD CargarFamilia_82CD(int idFamilia_82CD)
        {
            ServicioFamilia_82CD familia_82CD = mapperFamilia_82CD.BuscarFamiliaPorID_82CD(idFamilia_82CD);

            if (familia_82CD == null)
                return null;

            familia_82CD = mapperFamilia_82CD.CargarElementosFamilia_82CD(idFamilia_82CD);
            return familia_82CD;
        }


        public void CrearFamilia_82CD(ServicioFamilia_82CD NuevaFamilia_82CD)
        {
            if (mapperFamilia_82CD.ExisteFamilia_82CD(NuevaFamilia_82CD.Nombre_82CD))
                throw new Exception("Ya existe una familia con ese nombre.");

            // Carga el arbol de cada sub-Familia seleccionada para poder leer sus permisos y poder validar duplicados

            List<ServicioFamilia_82CD> subfamiliasConArbol_82CD = new List<ServicioFamilia_82CD>();

            foreach (ServicioFamilia_82CD famSeleccionada_82CD in NuevaFamilia_82CD.familiasSeleccionadas_82CD)
            {
                ServicioFamilia_82CD arbol_82CD = mapperFamilia_82CD.CargarElementosFamilia_82CD(famSeleccionada_82CD.IdFamilia_82CD);
                subfamiliasConArbol_82CD.Add(arbol_82CD);
            }

            ValidarPermisosSinRepetir_82CD(NuevaFamilia_82CD.permisosSeleccionados_82CD, subfamiliasConArbol_82CD);

            // Persiste la Familia, luego sus relaciones
            int IdNuevaFamilia82CD = mapperFamilia_82CD.CrearFamilia_82CD(NuevaFamilia_82CD);

            if (NuevaFamilia_82CD.permisosSeleccionados_82CD.Count > 0)
                mapperFamilia_82CD.AgregarPermisosAFamilia_82CD(IdNuevaFamilia82CD, NuevaFamilia_82CD.permisosSeleccionados_82CD);

            if (NuevaFamilia_82CD.familiasSeleccionadas_82CD.Count > 0)
                mapperFamilia_82CD.AgregarFamiliasAFamilia_82CD(IdNuevaFamilia82CD, NuevaFamilia_82CD.familiasSeleccionadas_82CD);

            ServicioUsuario_82CD usuario_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Crear Familia", "Administrador", 2);
        }

        public void EliminarFamilia_82CD(ServicioFamilia_82CD Familia_82CD)
        {
            if (mapperFamilia_82CD.FamiliaExisteEnOtraFamilia_82CD(Familia_82CD.IdFamilia_82CD))
                throw new Exception("La familia no puede eliminarse porque otra familia la contiene.");

            if (mapperFamilia_82CD.FamiliaExisteEnOtroRol_82CD(Familia_82CD.IdFamilia_82CD))
                throw new Exception("La familia no puede eliminarse porque está asignada a un rol.");

            mapperFamilia_82CD.EliminarFamilia_82CD(Familia_82CD.IdFamilia_82CD);

            ServicioUsuario_82CD usuario_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Eliminar Familia", "Administrador", 3);
        }


        private void ValidarPermisosSinRepetir_82CD(List<ServicioPermiso_82CD> PermisosDirectos_82CD, List<ServicioFamilia_82CD> SubfamiliasConArbol_82CD)
        {
            List<int> idsPermisosTotales_82CD = new List<int>();

            foreach (ServicioPermiso_82CD permiso_82CD in PermisosDirectos_82CD)
            {
                if (idsPermisosTotales_82CD.Contains(permiso_82CD.IdPermiso_82CD))
                    throw new Exception("El permiso '" + permiso_82CD.Nombre_82CD + "' está repetido.");

                idsPermisosTotales_82CD.Add(permiso_82CD.IdPermiso_82CD);
            }

            foreach (ServicioFamilia_82CD subFamilia_82CD in SubfamiliasConArbol_82CD)
            {
                foreach (ServicioPermiso_82CD permiso_82CD in subFamilia_82CD.ObtenerPermisos_82CD())
                {
                    if (idsPermisosTotales_82CD.Contains(permiso_82CD.IdPermiso_82CD))
                        throw new Exception("El permiso '" + permiso_82CD.Nombre_82CD + "' ya está incluido en una familia seleccionada.");

                    idsPermisosTotales_82CD.Add(permiso_82CD.IdPermiso_82CD);
                }
            }
        }


    }
}
