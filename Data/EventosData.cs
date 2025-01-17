using chaknuul_services.Models;

namespace chaknuul_services.Data
{
    public class EventosData
    {

        private static EventosData instanceDA;
        public static EventosData InstanceDA
        {
            get
            {
                if (instanceDA == null)
                {
                    return new EventosData();
                }
                return instanceDA;
            }
        }
        public List<Evento> GetEventos() 
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                return context.Eventos.Where(w => w.Fecha >= DateTime.Now).ToList();
            }
        }

        internal List<EventosV2> GetEventosV2()
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                return context.EventosV2s.Where(w => w.Fecha >= DateTime.Now).ToList();
            }
        }

        internal List<Partner> GetPartners()
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                return context.Partners.ToList();
            }
        }

        internal Evento GetProximo()
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                Evento eve = context.Eventos.Where(w => w.Fecha >= DateTime.Now && w.Foco == true).FirstOrDefault();
                if (eve != null) {
                    return eve;
                }
                else
                {
                    return context.Eventos.Where(w => w.Fecha >= DateTime.Now).OrderBy(o => o.Fecha).FirstOrDefault();
                }
            }
        }
    }
}
