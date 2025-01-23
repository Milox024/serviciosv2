
using chaknuul_services.Data;
using chaknuul_services.Models;
using static System.Net.Mime.MediaTypeNames;
using Convert = System.Convert;
using MemoryStream = System.IO.MemoryStream;
using System.Buffers.Text;
using Image = System.Drawing;
using System.Drawing;

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

        internal Evento AddOrUpdateEvent(Evento evento)
        {
            return CmData.InstanceDA.AddOrUpdateEvent(evento);
        }

        internal object AddOrUpdateEventV2(EventosV2 data)
        {
            return CmData.InstanceDA.AddOrUpdateEventV2(data);
        }

        internal object CloneEvent(int eid, DateTime fecha)
        {
            return CmData.InstanceDA.CloneEvent(eid, fecha);
        }

        internal bool DeleteEvent(int idEvento)
        {
            return CmData.InstanceDA.DeleteEvent(idEvento);
        }

        internal List<Evento> GetEventsAdmin()
        {
            return CmData.InstanceDA.GetEventsAdmin();
        }

        internal List<Tipo> GetTipos()
        {
            return CmData.InstanceDA.GetTipos();
        }

        internal object UpdateEventStatus(int data)
        {
            return CmData.InstanceDA.UpdateEventStatus(data);
        }
    }
}
