using Servicio;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLRol_82CD
    {
        private MapperRol_82CD mapperRol_82CD = new MapperRol_82CD();
        private BLLEvento_82CD bllEvento_82CD = new BLLEvento_82CD();

        public List<ServicioRol_82CD> ObtenerRoles_82CD()
        {
            return mapperRol_82CD.ObtenerRoles_82CD();
        }

        public ServicioRol_82CD BuscarRolporID_82CD(int idRol_82CD)
        {
            return mapperRol_82CD.BucarRolPorID_82CD(idRol_82CD);
        }

        public ServicioRol_82CD CargarRol_82CD(int idRol_82CD)
        {
            ServicioRol_82CD rol_82CD = mapperRol_82CD.BucarRolPorID_82CD(idRol_82CD);
            
            if (rol_82CD == null)
                return null;

            mapperRol_82CD.CargarElementosDelRol_82CD(rol_82CD);
            return rol_82CD;
        }

        public void CrearRol_82CD(ServicioRol_82CD Rol_82CD)
        {
            if (mapperRol_82CD.ExisteRol_82CD(Rol_82CD.NombreRol_82CD))
                throw new Exception("Ya existe un Rol con ese nombre.");

            // Carga el arbol de cada Familia seleccionada, para poder leer sus permisos y poder validar duplicados

            MapperFamilia_82CD mapperFamilia_82CD = new MapperFamilia_82CD();
            List<ServicioFamilia_82CD> familiasConArbol_82CD = new List<ServicioFamilia_82CD>();

            foreach (ServicioFamilia_82CD famSeleccionada_82CD in Rol_82CD.FamiliasSeleccionadas_82CD)
            {
                ServicioFamilia_82CD arbol_82CD = mapperFamilia_82CD.CargarElementosFamilia_82CD(famSeleccionada_82CD.IdFamilia_82CD);
                familiasConArbol_82CD.Add(arbol_82CD);
            }

            ValidarPermisosSinRepetir_82CD(Rol_82CD.PermisosSeleccionados_82CD, familiasConArbol_82CD);

            // Persiste el Rol, luego sus relaciones
            int IdNuevoRol_82CD = mapperRol_82CD.CrearRol_82CD(Rol_82CD);

            if (Rol_82CD.FamiliasSeleccionadas_82CD.Count > 0)
                mapperRol_82CD.AgregarFamiliasARol_82CD(IdNuevoRol_82CD, Rol_82CD.FamiliasSeleccionadas_82CD);

            if (Rol_82CD.PermisosSeleccionados_82CD.Count > 0)
                mapperRol_82CD.AgregarPermisosARol_82CD(IdNuevoRol_82CD, Rol_82CD.PermisosSeleccionados_82CD);

            ServicioUsuario_82CD usuario_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Crear Rol", "Administrador", 2);
        }

        public void EliminarRol_82CD(ServicioRol_82CD Rol_82CD)
        {
            if (mapperRol_82CD.RolEstaEnUsuario_82CD(Rol_82CD.IdRol_82CD))
                throw new Exception("El rol no puede eliminarse porque está asignado a un usuario.");

            mapperRol_82CD.EliminarRol_82CD(Rol_82CD.IdRol_82CD);

            ServicioUsuario_82CD usuario_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Eliminar Rol", "Administrador", 3);
        }


        private void ValidarPermisosSinRepetir_82CD(List<ServicioPermiso_82CD> PermisosDirectos_82CD, List<ServicioFamilia_82CD> Familias_82CD)
        {
            List<int> idsPermisosTotales_82CD = new List<int>();

            foreach (ServicioPermiso_82CD permiso_82CD in PermisosDirectos_82CD)
            {
                if (idsPermisosTotales_82CD.Contains(permiso_82CD.IdPermiso_82CD))
                    throw new Exception("El permiso '" + permiso_82CD.Nombre_82CD + "' está repetido.");
                
                idsPermisosTotales_82CD.Add(permiso_82CD.IdPermiso_82CD);
            }

            foreach (ServicioFamilia_82CD familia_82CD in Familias_82CD)
            {
                foreach (ServicioPermiso_82CD permiso_82CD in familia_82CD.ObtenerPermisos_82CD())
                {
                    if (idsPermisosTotales_82CD.Contains(permiso_82CD.IdPermiso_82CD))
                        throw new Exception("El permiso '" + permiso_82CD.Nombre_82CD + "' ya está incluido en una familia seleccionada.");
                
                    idsPermisosTotales_82CD.Add(permiso_82CD.IdPermiso_82CD);
                }
            }
        }

        public void VerificarRolesBase_82CD()
        {
            mapperRol_82CD.CrearRolesBase_82CD();
        }
    
    }
}
