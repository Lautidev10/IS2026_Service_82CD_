using BE;
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

        public List<BERol_82CD> ObtenerRoles_82CD()
        {
            return mapperRol_82CD.ObtenerRoles_82CD();
        }

        public BERol_82CD BuscarRolporID_82CD(int idRol_82CD)
        {
            return mapperRol_82CD.BucarRolPorID_82CD(idRol_82CD);
        }

        
    }
}
