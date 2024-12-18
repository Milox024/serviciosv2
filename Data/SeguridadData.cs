using chaknuul_services.Models;
using System.Security.Cryptography;
using System.Text;

namespace chaknuul_services.Data
{
    public class SeguridadData
    {
        private static SeguridadData instanceDA;
        public static SeguridadData InstanceDA
        {
            get
            {
                if (instanceDA == null)
                {
                    return new SeguridadData();
                }
                return instanceDA;
            }
        }

        public UsuariosAdmin GetValidUser(UsuarioLogin usuario) 
        {
            using (var context = new DbAae570Chaknuul2024Context()) 
            {
                UsuariosAdmin user = context.UsuariosAdmins.Where(w => w.Usuario.Equals(usuario.Usuario)).FirstOrDefault();
                if (user != null) 
                {
                    if (user.Password.Equals(usuario.Password)) 
                    {
                        PseudoToken pt = new PseudoToken
                        {
                            Usuario = usuario.Usuario,
                            Guid = Guid.NewGuid().ToString(),
                            Creacion = DateTime.Now,
                            Vigencia = DateTime.Now.AddHours(1)
                        };
                        context.PseudoTokens.Add(pt);
                        user.GuidActivo = pt.Guid;
                        context.UsuariosAdmins.Update(user);
                        context.SaveChanges();
                        return user;
                    }
                }
                return null;
            }
        }
        private static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        internal bool ValidaReferencia(string referencia)
        {
            int refe = 0;
            using (var context = new DbAae570Chaknuul2024Context()) 
            {
                refe = context.PseudoTokens.Where(w => w.Guid.Equals(referencia) && w.Vigencia > DateTime.Now).Count();
            }
            return refe > 0;
        }
    }
}
