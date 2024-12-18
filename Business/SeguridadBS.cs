using chaknuul_services.Data;
using chaknuul_services.Models;

namespace chaknuul_services.Business
{
    public class SeguridadBS
    {
        private static SeguridadBS instanceBS;
        public static SeguridadBS InstanceBS
        {
            get
            {
                if (instanceBS == null)
                {
                    return new SeguridadBS();
                }
                return instanceBS;
            }
        }

        public UsuariosAdmin GetValidUser(UsuarioLogin usu) 
        {
            return SeguridadData.InstanceDA.GetValidUser(usu);
        }

        internal bool ValidaReferencia(string referencia)
        {
            return SeguridadData.InstanceDA.ValidaReferencia(referencia);
        }
    }
}
