using chaknuul_services.Models;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    data.FechaEdicion = DateTime.Now;
                    context.Eventos.Update(data);
                }
                context.SaveChanges();
            }
            return data;
        }

        internal EventosV2 AddOrUpdateEventV2(EventosV2 data)
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

        internal object CloneEvent(int eid, DateTime fecha)
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                Evento e = context.Eventos.Where(w => w.Id == eid).FirstOrDefault();
                e.Id = 0;
                e.Fecha = fecha;
                e.FechaCreacion = DateTime.Now;
                e.FechaEdicion = DateTime.Now;
                context.Eventos.Add(e);
                context.SaveChanges();
                return e;
            }
        }

        internal bool DeleteEvent(int idEvento)
        {
            using (var context = new DbAae570Chaknuul2024Context())
            {
                Evento e = context.Eventos.Where(w => w.Id == idEvento).FirstOrDefault();
                context.Eventos.Remove(e);
                context.SaveChanges();
            }
            return true;
        }

        internal List<Evento> GetEventsAdmin()
        {
            List<Evento> listaReturn = new List<Evento>();
            List<Evento> listaInactivos = new List<Evento>();
            using (var context = new DbAae570Chaknuul2024Context())
            {
                listaReturn = context.Eventos.Where(w => w.Activo == true).OrderBy(o => o.Fecha).ToList();
                listaInactivos = context.Eventos.Where(w => w.Activo == false).OrderBy(o => o.Fecha).ToList();
            }
            return listaReturn.Union(listaInactivos).ToList();
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
