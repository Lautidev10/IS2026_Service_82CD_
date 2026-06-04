
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace BLL
{
    public class BLLUsuario_82CD
    {
        private MapperUsuario_82CD mapperUsuario_82CD = new MapperUsuario_82CD();
        private BLLEvento_82CD bllEvento_82CD = new BLLEvento_82CD();

        public List<ServicioUsuario_82CD> ListarUsuario_82CD(bool estado_82CD)
        {
            return mapperUsuario_82CD.ListarUsuario_82CD(estado_82CD);
        }


        public ServicioUsuario_82CD ValidarCredenciales_82CD(string login_82CD, string contraseña_82CD)
        {
            ServicioUsuario_82CD usuario_82CD = mapperUsuario_82CD.BuscarUsuarioPorLogIn_82CD(login_82CD);

            if (usuario_82CD == null)
            {
                throw new Exception("Usuario o Contraseña Incorrectos");
            }

            if (!usuario_82CD.Activo_82CD)
            {
                throw new Exception("El usuario se encuentra inactivo");
            }

            if (usuario_82CD.Bloqueado_82CD)
            {
                throw new Exception("El usuario se encuentra bloqueado");
            }

            string contraseñaEncriptada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(contraseña_82CD);

            if (usuario_82CD.Password_82CD != contraseñaEncriptada_82CD)
            {
                int intentos_82CD = MonitorAcceso_82CD.RegistrarIntentoFallido_82CD(login_82CD);

                if (MonitorAcceso_82CD.Bloquear(login_82CD))
                {
                    mapperUsuario_82CD.BloquearUsuario_82CD(usuario_82CD.DNI_82CD);

                    bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Bloquear Usuario", "Login", 1);

                    throw new Exception("Su usuario fue bloqueado por exceso de intentos, debe comunicarse con un administrador");
                }

                throw new Exception("Usuario o Contraseña Incorrectos: Intento " + intentos_82CD + " de 3");
            }

            ServicioUsuario_82CD usuarioSesion_82CD = null;

            try
            {
                usuarioSesion_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            }
            catch
            {
            }

            if (usuarioSesion_82CD != null)
            {
                if (usuarioSesion_82CD.LogIn_82CD == usuario_82CD.LogIn_82CD)
                {
                    throw new Exception("El usuario ya tiene una sesión iniciada");
                }
                else
                {
                    throw new Exception("Bienvenido al sistema");
                }
            }

            SessionManager_82CD.IniciarSesion_82CD(usuario_82CD);

            MonitorAcceso_82CD.EliminarIntentos_82CD(login_82CD);

            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Iniciar Sesión", "Login", 1);

            return usuario_82CD;
        }

        public void AgregarUsuario_82CD(ServicioUsuario_82CD usuario_82CD)
        {
            List<ServicioUsuario_82CD> listaTotal_82CD = mapperUsuario_82CD.ListarUsuario_82CD(false);

            if (listaTotal_82CD.Exists(u => u.DNI_82CD == usuario_82CD.DNI_82CD))
            {
                throw new Exception("El DNI ya existe en el sistema.");
            }

            if (listaTotal_82CD.Exists(u => u.LogIn_82CD == usuario_82CD.LogIn_82CD))
            {
                throw new Exception("Ese usuario ya existe en el sistema.");
            }

            usuario_82CD.LogIn_82CD = usuario_82CD.Nombre_82CD.Replace(" ", "") + usuario_82CD.DNI_82CD;
            string passwordSinEncriptar_82CD = usuario_82CD.Apellidos_82CD.Replace(" ", "") + usuario_82CD.DNI_82CD;

            usuario_82CD.Password_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(passwordSinEncriptar_82CD);

            mapperUsuario_82CD.AgregarUsuario_82CD(usuario_82CD);

            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Crear Usuario", "Admin", 1);
        }

        public void ModificarUsuario_82CD(ServicioUsuario_82CD usuario_82CD)
        {
            if (string.IsNullOrWhiteSpace(usuario_82CD.DNI_82CD))
                throw new Exception("El DNI no puede estar vacio");

            mapperUsuario_82CD.ModificarUsuario_82CD(usuario_82CD);

            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Modificar Usuario", "Admin", 2);
        }

        public void CambiarEstadoUsuario_82CD(ServicioUsuario_82CD usuario_82CD, bool estado_82CD)
        {
            ServicioUsuario_82CD sesion_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            
            if(usuario_82CD.LogIn_82CD == sesion_82CD.LogIn_82CD)
            {
                throw new Exception("No podes desactivar tu sesion");
            }

            mapperUsuario_82CD.CambiarEstadoUsuario_82CD(usuario_82CD, estado_82CD);

            if (estado_82CD)
            {
                bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Activar Usuario", "Admin", 1);
            }
            else
            {
                bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Desactivar Usuario", "Admin", 1);
            }
        }


        public void DesbloquearUsuario_82CD(ServicioUsuario_82CD usuario_82CD)
        {
            string passwordSinEncriptar_82CD = usuario_82CD.Apellidos_82CD.Replace(" ", "") + usuario_82CD.DNI_82CD;

            usuario_82CD.Password_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(passwordSinEncriptar_82CD);

            mapperUsuario_82CD.DesbloquearUsuario_82CD(usuario_82CD.DNI_82CD, usuario_82CD.Password_82CD);
            MonitorAcceso_82CD.EliminarIntentos_82CD(usuario_82CD.LogIn_82CD);

            bllEvento_82CD.RegistrarEvento_82CD(usuario_82CD.LogIn_82CD, "Desbloquear Usuario", "Admin", 1);
        }

        public void ActualizarContraseña_82CD(string PasswordActual_82CD, string PasswordNueva_82CD, string Confirmacion_82CD)
        {
            ServicioUsuario_82CD UsuarioActual_82CD = SessionManager_82CD.ObtenerUsuario_82CD();

            if (PasswordNueva_82CD != Confirmacion_82CD)
            {
                throw new Exception("La contraseña nueva no coincide con la confirmacion");
            }

            string PassActualIngresadaHasheada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(PasswordActual_82CD);

            if (UsuarioActual_82CD.Password_82CD != PassActualIngresadaHasheada_82CD)
            {
                throw new Exception("La contraseña actual es incorrecta");
            }

            if(PasswordActual_82CD == PasswordNueva_82CD)
            {
                throw new Exception("La nueva contraseña no puede ser igual que la actual");
            }

            string PasswordNuevaEncriptada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(PasswordNueva_82CD);

            mapperUsuario_82CD.ActualizarContraseña_82CD(UsuarioActual_82CD.DNI_82CD, PasswordNuevaEncriptada_82CD);
            UsuarioActual_82CD.Password_82CD = PasswordNuevaEncriptada_82CD;
            
            SessionManager_82CD.ActualizarUsuarioEnSesion_82CD(UsuarioActual_82CD);
            bllEvento_82CD.RegistrarEvento_82CD(UsuarioActual_82CD.LogIn_82CD,"Cambiar Contraseña","Usuario",1);
        }

        public void CerrarSesion_82CD()
        {
            ServicioUsuario_82CD UsuarioActual_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            bllEvento_82CD.RegistrarEvento_82CD(UsuarioActual_82CD.LogIn_82CD, "Cerrar Sesión", "Usuario", 1);
            SessionManager_82CD.CerrarSesion_82CD();
        }

    }

}
