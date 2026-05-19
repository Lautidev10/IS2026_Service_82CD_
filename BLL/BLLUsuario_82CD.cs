using BE;
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
        private BLLBitacora_82CD bllBitacora_82CD = new BLLBitacora_82CD();

        public List<UsuarioBE_82CD> ListarUsuario_82CD(bool estado_82CD)
        {
            return mapperUsuario_82CD.ListarUsuario_82CD(estado_82CD);
        }


        public UsuarioBE_82CD ValidarCredenciales_82CD(string login_82CD, string contraseña_82CD)
        {
            UsuarioBE_82CD usuario_82CD = mapperUsuario_82CD.BuscarUsuarioPorLogIn_82CD(login_82CD);
            string contraseñaEncriptada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(contraseña_82CD);

            if (usuario_82CD == null)
            {
                throw new Exception("Usuario o Contraseña Incorrectos");
            }
            if (!usuario_82CD.Activo_82CD)
            {
                bllBitacora_82CD.RegistrarEvento_82CD(
                    "Intento de inicio de sesion de usuario inactivo",
                    login_82CD
                    );

                throw new Exception("El usuario se encuentra inactivo");
            }
            if (usuario_82CD.Bloqueado_82CD)
            {
                bllBitacora_82CD.RegistrarEvento_82CD(
                    "Intento de inicio de sesion de usuario bloqueado",
                    login_82CD
                    );

                throw new Exception("El usuario se encuentra bloqueado");
            }
            if(usuario_82CD.Password_82CD != contraseñaEncriptada_82CD)
            {
                int intentos_82CD = MonitorAcceso_82CD.RegistrarIntentoFallido_82CD(login_82CD);

                if (MonitorAcceso_82CD.Bloquear(login_82CD))
                {
                    mapperUsuario_82CD.BloquearUsuario_82CD(usuario_82CD.DNI_82CD);

                    bllBitacora_82CD.RegistrarEvento_82CD(
                    "Usuario bloqueado por exceso de intentos fallidos",
                    login_82CD
                    );

                    throw new Exception("Su usuario fue bloqueado por exceso de intentos, debe comunicarse con un administrador");
                }

                throw new Exception("Usuario o Contraseña Incorrectos: Intento "+ intentos_82CD + " de 3");
            }
            SessionManager_82CD.IniciarSesion_82CD(usuario_82CD);
            MonitorAcceso_82CD.EliminarIntentos_82CD(login_82CD);

            bllBitacora_82CD.RegistrarEvento_82CD(
                    "Inicio de sesion exitoso",
                    login_82CD
                    );

            return usuario_82CD;
        }

        public void AgregarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            List<UsuarioBE_82CD> listaTotal_82CD = mapperUsuario_82CD.ListarUsuario_82CD(false);

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

            bllBitacora_82CD.RegistrarEvento_82CD("Se creo usuario con exito", usuario_82CD.LogIn_82CD);
        }

        public void ModificarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            if (string.IsNullOrWhiteSpace(usuario_82CD.DNI_82CD))
                throw new Exception("El DNI no puede estar vacio");

            mapperUsuario_82CD.ModificarUsuario_82CD(usuario_82CD);

            bllBitacora_82CD.RegistrarEvento_82CD("Usuario modificado con exito", usuario_82CD.LogIn_82CD);
        }

        public void CambiarEstadoUsuario_82CD(UsuarioBE_82CD usuario_82CD, bool estado_82CD)
        {
            UsuarioBE_82CD sesion_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            
            if(usuario_82CD.LogIn_82CD == sesion_82CD.LogIn_82CD)
            {
                throw new Exception("No podes desactivar tu sesion");
            }

            mapperUsuario_82CD.CambiarEstadoUsuario_82CD(usuario_82CD, estado_82CD);

            if (estado_82CD)
            {
                bllBitacora_82CD.RegistrarEvento_82CD(
                    "Se activo usuario de forma exitosa",
                    usuario_82CD.LogIn_82CD
                );
            }
            else
            {
                bllBitacora_82CD.RegistrarEvento_82CD(
                    "Se desactivo usuario de forma exitosa",
                    usuario_82CD.LogIn_82CD
                );
            }
        }


        public void DesbloquearUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            string passwordSinEncriptar_82CD = usuario_82CD.Apellidos_82CD.Replace(" ", "") + usuario_82CD.DNI_82CD;

            usuario_82CD.Password_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(passwordSinEncriptar_82CD);

            mapperUsuario_82CD.DesbloquearUsuario_82CD(usuario_82CD.DNI_82CD, usuario_82CD.Password_82CD);
            MonitorAcceso_82CD.EliminarIntentos_82CD(usuario_82CD.LogIn_82CD);

            bllBitacora_82CD.RegistrarEvento_82CD("Desbloqueo de usuario exitoso", usuario_82CD.LogIn_82CD);
        }

        public void ActualizarContraseña_82CD(string PasswordActual_82CD, string PasswordNueva_82CD, string Confirmacion_82CD)
        {
            UsuarioBE_82CD UsuarioActual_82CD = SessionManager_82CD.ObtenerUsuario_82CD();

            if (PasswordNueva_82CD != Confirmacion_82CD)
            {
                throw new Exception("La contraseña nueva no coincide con la confirmacion");
            }

            string PassActualIngresadaHasheada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(PasswordActual_82CD);

            if (UsuarioActual_82CD.Password_82CD != PassActualIngresadaHasheada_82CD)
            {
                throw new Exception("La contraseña es incorrecta");
            }

            if(PasswordActual_82CD == PasswordNueva_82CD)
            {
                throw new Exception("La nueva contraseña no puede ser igual que la actual");
            }

            string PasswordNuevaEncriptada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(PasswordNueva_82CD);

            mapperUsuario_82CD.ActualizarContraseña_82CD(UsuarioActual_82CD.DNI_82CD, PasswordNuevaEncriptada_82CD);

            UsuarioActual_82CD.Password_82CD = PasswordNuevaEncriptada_82CD;
            SessionManager_82CD.ActualizarUsuarioEnSesion_82CD(UsuarioActual_82CD);

            bllBitacora_82CD.RegistrarEvento_82CD("Cambio de Clave Exitoso", UsuarioActual_82CD.LogIn_82CD);
        }


    }

}
