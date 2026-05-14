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


        public UsuarioBE_82CD ValidarCredenciales_82CD(string login_82CD, string contraseñaEncriptada_82CD)
        {
            UsuarioBE_82CD usuario_82CD = mapperUsuario_82CD.BuscarUsuarioPorLogIn_82CD(login_82CD);
            if(usuario_82CD == null)
            {
                //La bitacora podria guardar el intento fallido
                throw new Exception("Usuario o Contraseña Incorrectos");
            }
            if (!usuario_82CD.Activo_82CD)
            {
                //bllBitacora_82CD.RegistrarEvento_82CD("Intento de conexion de usuario inactivo: {1}", login_82CD);
                throw new Exception("El usuario se encuentra inactivo");
            }
            if (usuario_82CD.Bloqueado_82CD)
            {
                //bllBitacora_82CD.RegistrarEvento_82CD("Intento de conexion de usuario bloqueado:{0}", login_82CD);
                throw new Exception("El usuario se encuentra bloqueado");
            }
            if(usuario_82CD.Password_82CD != contraseñaEncriptada_82CD)
            {
                //La bitacora podria guardar el intendo fallido
                throw new Exception("Usuario o Contraseña Incorrectos");
            }
            if(usuario_82CD != null && usuario_82CD.LogIn_82CD != login_82CD)
            {
                throw new Exception("Usuario o Contraseña Incorrectos");
            }

            //bllBitacora_82CD.RegistrarEvento_82CD("El usuario {0} inicio sesion",login_82CD);

            return usuario_82CD;
        }

        public string AgregarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            List<UsuarioBE_82CD> listaTotal_82CD = mapperUsuario_82CD.ListarUsuario_82CD(false);

            usuario_82CD.LogIn_82CD = usuario_82CD.Nombre_82CD + usuario_82CD.DNI_82CD;

            string passwordSinEncriptar_82CD = usuario_82CD.Apellidos_82CD + usuario_82CD.DNI_82CD;

            usuario_82CD.Password_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(passwordSinEncriptar_82CD);

            if (listaTotal_82CD.Exists(u => u.DNI_82CD == usuario_82CD.DNI_82CD))
            {
                throw new Exception("El DNI ya existe en el sistema.");
            }

            if (listaTotal_82CD.Exists(u => u.LogIn_82CD == usuario_82CD.LogIn_82CD))
            {
                throw new Exception("Ese usuario ya existe en el sistema.");
            }

            mapperUsuario_82CD.AgregarUsuario_82CD(usuario_82CD);

            return "Usuario creado correctamente \n\n" +
                "Usuario: " + usuario_82CD.LogIn_82CD +
                "Contraseña: " + passwordSinEncriptar_82CD;
        }

        public void ModificarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            if (string.IsNullOrWhiteSpace(usuario_82CD.DNI_82CD))
                //throw new Exception("Nombre y Apellido no pueden estar vacios");
                throw new Exception("El DNI no puede estar vacio");

            mapperUsuario_82CD.ModificarUsuario_82CD(usuario_82CD);
        }

        public void CambiarEstadoUsuario_82CD(UsuarioBE_82CD usuario_82CD, bool estado_82CD)
        {
            if(usuario_82CD == null)
            {
                throw new Exception("Debe seleccionar un usuario");
            }
            
            UsuarioBE_82CD sesion_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            
            if(usuario_82CD.LogIn_82CD == sesion_82CD.LogIn_82CD)
            {
                throw new Exception("No podes desactivar tu sesion");
            }

            mapperUsuario_82CD.CambiarEstadoUsuario_82CD(usuario_82CD, estado_82CD);
        }


        public void DesbloquearUsuario_82CD(String Login_82CD, string Password_82CD)
        {
            mapperUsuario_82CD.DesbloquearUsuario_82CD(Login_82CD, Password_82CD);
        }

        /*public void ActualizarContraseña_82CD(string Login_82CD, string PasswordActual_82CD, string PasswordNueva_82CD, string Confirmacion_82CD)
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

            string PasswordNuevaEncriptada_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(PasswordNueva_82CD);

            mapperUsuario_82CD.ActualizarContraseña_82CD(UsuarioActual_82CD.DNI_82CD, PasswordNuevaEncriptada_82CD);

            UsuarioActual_82CD.Password_82CD = PasswordNuevaEncriptada_82CD;
            SessionManager_82CD.ActualizarUsuarioEnSesion_82CD(UsuarioActual_82CD);

            bllBitacora_82CD.RegistrarEvento_82CD("Cambio de Clave Exitoso", UsuarioActual_82CD.LogIn_82CD);
        }*/


    }

}
