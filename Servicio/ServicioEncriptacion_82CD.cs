using System.Security.Cryptography;
using System.Text;

namespace Servicio
{
    public class ServicioEncriptacion_82CD
    {
        public static string Encriptar_82CD(string texto_82CD)
        {
            if (string.IsNullOrEmpty(texto_82CD)) return string.Empty;

            using (SHA256 sha_82CD = SHA256.Create())
            {
                byte[] bytes_82CD = Encoding.UTF8.GetBytes(texto_82CD);
                byte[] hash_82CD = sha_82CD.ComputeHash(bytes_82CD);

                StringBuilder sb_82CD = new StringBuilder();

                foreach (byte b in hash_82CD)
                {
                    sb_82CD.Append(b.ToString("x2"));
                }

                return sb_82CD.ToString();
            }
        }



    }
}