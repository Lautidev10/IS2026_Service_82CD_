using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ServicioHash_82CD
    {
        public static string GenerarHash_82CD (string texto_82CD)
        {
            SHA256 sha_82CD = SHA256.Create();

            byte[] bytes_82CD =
            Encoding.UTF8.GetBytes(texto_82CD);

            byte[] hash_82CD =
            sha_82CD.ComputeHash(bytes_82CD);

            StringBuilder sb_82CD =
            new StringBuilder();

            foreach (byte b in hash_82CD)
            {
                sb_82CD.Append(b.ToString("x2"));
            }

            return sb_82CD.ToString();
        }
    }
}
