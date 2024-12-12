using chaknuul_services.Data;
using chaknuul_services.Models;

namespace chaknuul_services.Business
{
    public class EventosBS
    {

        private static EventosBS instanceBS;
        public static EventosBS InstanceBS
        {
            get
            {
                if (instanceBS == null)
                {
                    return new EventosBS();
                }
                return instanceBS;
            }
        }

        public List<Evento> GetEventos()
        {
            return EventosData.InstanceDA.GetEventos();
        }

        internal Evento GetProximo()
        {
            return EventosData.InstanceDA.GetProximo();
        }
    }
}
