using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Servicio
{
    public class MonitorAcceso_82CD
    {
        //Se podria hacer otro diccionario que guarde los intentos por computadora para asegurar que nadie pueda intentar de averiguar un usuario del sistema

        private const int maxIntentos_82CD = 3;
        private static readonly string rutaArchivo_82CD = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IntentosFallidos_82CD.json");
        
        
        private static Dictionary<string, ServicioIntentosUsuario_82CD> CargarDiccionarioIntentos_82CD()
        {
            if (!File.Exists(rutaArchivo_82CD))
                return new Dictionary<string, ServicioIntentosUsuario_82CD>();

            string json_82CD = File.ReadAllText(rutaArchivo_82CD);

            Dictionary <string, ServicioIntentosUsuario_82CD> intentos_82CD = JsonConvert.DeserializeObject<Dictionary<string, ServicioIntentosUsuario_82CD>>(json_82CD);

            if(intentos_82CD == null)
            {
                return new Dictionary<string, ServicioIntentosUsuario_82CD>();
            }

            return intentos_82CD;
        }

        private static void GuardarDiccionarioIntentos_82CD(Dictionary<string, ServicioIntentosUsuario_82CD> intentos_82CD)
        {
            string json_82CD = JsonConvert.SerializeObject(intentos_82CD,Formatting.Indented);
            File.WriteAllText(rutaArchivo_82CD, json_82CD);
        }

        public static int RegistrarIntentoFallido_82CD(string login_82CD)
        {
            Dictionary<string, ServicioIntentosUsuario_82CD> intentos_82CD = CargarDiccionarioIntentos_82CD();

            if (!intentos_82CD.ContainsKey(login_82CD))
            {
                intentos_82CD[login_82CD] = new ServicioIntentosUsuario_82CD
                {
                    CantidadIntentos_82CD = 0,
                    FechaUltimoIntento_82CD = DateTime.Now
                };
            }

            ServicioIntentosUsuario_82CD intentosUsuario_82CD = intentos_82CD[login_82CD];

            // se reinicia el contador si pasaron mas de 5 horas
            if ((DateTime.Now - intentosUsuario_82CD.FechaUltimoIntento_82CD).TotalHours >= 5)
            {
                intentosUsuario_82CD.CantidadIntentos_82CD = 0;
            }

            intentosUsuario_82CD.CantidadIntentos_82CD++;
            intentosUsuario_82CD.FechaUltimoIntento_82CD = DateTime.Now;

            GuardarDiccionarioIntentos_82CD(intentos_82CD);

            return intentosUsuario_82CD.CantidadIntentos_82CD;
        }

        public static int ObtenerIntentos_82CD(string login_82CD)
        {
            Dictionary<string, ServicioIntentosUsuario_82CD> diccionarioIntentos_82CD = CargarDiccionarioIntentos_82CD();

            if (!diccionarioIntentos_82CD.ContainsKey(login_82CD))
            {
                return 0;
            }
            
            return diccionarioIntentos_82CD[login_82CD].CantidadIntentos_82CD;
        }

        public static bool Bloquear(string login_82CD)
        {
            return ObtenerIntentos_82CD(login_82CD) >= maxIntentos_82CD;

        }

        public static void EliminarIntentos_82CD(string login_82CD)
        {
            Dictionary<string, ServicioIntentosUsuario_82CD> diccionarioIntentos_82CD = CargarDiccionarioIntentos_82CD();

            if (diccionarioIntentos_82CD.ContainsKey(login_82CD))
            {
                diccionarioIntentos_82CD.Remove(login_82CD);
                GuardarDiccionarioIntentos_82CD(diccionarioIntentos_82CD);
            }
        }

    }
}
