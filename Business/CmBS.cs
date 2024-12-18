
using chaknuul_services.Data;
using chaknuul_services.Models;

namespace chaknuul_services.Business
{
    public class CmBS
    {
        private static CmBS instanceBS;
        public static CmBS InstanceBS
        {
            get
            {
                if (instanceBS == null)
                {
                    return new CmBS();
                }
                return instanceBS;
            }
        }

        internal Evento AddOrUpdateEvent(Evento data)
        {
            return CmData.InstanceDA.AddOrUpdateEvent(data);
        }

        internal List<Evento> GetEventsAdmin()
        {
            return CmData.InstanceDA.GetEventsAdmin();
        }
    }
}
