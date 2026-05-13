using BE;
using System;

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

        public static void IniciarSesion_82CD(UsuarioBE_82CD usuarioBE_82CD)
        {
            if(_usuario_82CD == null)
            {
                _usuario_82CD = usuarioBE_82CD;
            }
            else
            {
                throw new Exception("Ya hay una sesion Iniciada");
            }
            
        }

        public static void CerrarSesion_82CD()
        {
            _usuario_82CD = null;
        }

    }
}
