using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SessionManager_82CD
    {
        private static UsuarioBE_82CD _usuario_82CD;

        public static UsuarioBE_82CD ObtenerUsuario_82CD()
        {
            if (_usuario_82CD == null) throw new Exception("No hay sesión activa");
            return _usuario_82CD;
        }

        public static void ActualizarUsuarioEnSesion_82CD(UsuarioBE_82CD usuarioActualizado_82CD)
        {
            _usuario_82CD = usuarioActualizado_82CD;
        }


    }
}
