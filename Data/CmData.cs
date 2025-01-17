using chaknuul_services.Models;

namespace chaknuul_services.Data
{
    public class CmData
    {
        private static CmData instanceDA;
        public static CmData InstanceDA
        {
            get
            {
                if (instanceDA == null)
                {
                    return new CmData();
                }
                return instanceDA;
            }
        }

        internal Evento AddOrUpdateEvent(Evento data)
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                if (data.Id == 0)
                {
                    context.Eventos.Add(data);
                }
                else 
                {
                    context.Eventos.Update(data);
                }
                context.SaveChanges();
            }
            return data;
        }

        internal object AddOrUpdateEventV2(EventosV2 data)
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                if (data.Id == 0)
                {
                    context.EventosV2s.Add(data);
                }
                else
                {
                    context.EventosV2s.Update(data);
                }
                context.SaveChanges();
            }
            return data;
        }

        internal List<Evento> GetEventsAdmin()
        {
            using (var context = new DbAae570Chaknuul2024Context()) 
            {
                return context.Eventos.ToList();
            }
        }

        internal List<Tipo> GetTipos()
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                return context.Tipos.ToList();
            }
        }

        internal bool UpdateEventStatus(int eventId)
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                Evento e = context.Eventos.Where(w => w.Id == eventId).FirstOrDefault();
                e.Activo = !e.Activo;
                context.Eventos.Update(e);
                context.SaveChanges();
            }
            return true;
        }
    }
}
