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

        //Estructura recursiva para reconstruir las relaciones entre familias desde la BD.

        //ABM FAMILIAS

        //AgregarPermisosaFamilia
        //AgregarFamiliasaFamilia

        //Validaciones para que los permisos no se pisen y que no se puedan eliminar familias que sean utilizadas por un usuario mediante rol

    }
}
