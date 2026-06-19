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


        //ABM Roles

        //Verificar si un rol es utilizado por algun usuario recorriendo con la DAL

        //Asignaar los permisos y cargar familias (con los permisos y familias que puede contener una familia) relacionados al rol con la lista de elementos
    }
}
