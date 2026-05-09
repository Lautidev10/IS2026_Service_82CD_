using BE;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLUsuario_82CD
    {
        private MapperUsuario_82CD mapperUsuario_82CD = new MapperUsuario_82CD();
        private BLLBitacora_82CD bLLBitacora_82CD = new BLLBitacora_82CD();

        public List<UsuarioBE_82CD> ListarUsuario_82CD(bool soloActivos_82CD)
        {
            return mapperUsuario_82CD.ListarUsuario_82CD(soloActivos_82CD);
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

            mapperUsuario_82CD.AgregarUsuario_82CD(usuario_82CD);
        }

        public void ModificarUsuario_82CD(UsuarioBE_82CD usuario_82CD)
        {
            if (string.IsNullOrWhiteSpace(usuario_82CD.DNI_82CD))
                //throw new Exception("Nombre y Apellido no pueden estar vacios");
                throw new Exception("El DNI no puede estar vacio");

            mapperUsuario_82CD.ModificarUsuario_82CD(usuario_82CD);
        }

        public void CambiarEstadoUsuario_82CD(string dni_82CD, bool activo_82CD)
        {
            mapperUsuario_82CD.CambiarEstadoUsuario_82CD(dni_82CD, activo_82CD);
        }

        public void DesbloquearUsuario_82CD(String Login_82CD, string Password_82CD)
        {
            mapperUsuario_82CD.DesbloquearUsuario_82CD(Login_82CD, Password_82CD);
        }

        public void ActualizarContraseña_82CD(string Login_82CD, string PasswordActual_82CD, string PasswordNueva_82CD, string Confirmacion_82CD)
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

            bLLBitacora_82CD.RegistrarEvento_82CD("Cambio de Clave Exitoso", UsuarioActual_82CD.LogIn_82CD);
        }


    }

}
