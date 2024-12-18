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

        internal List<Evento> GetEventsAdmin()
        {
            using (var context = new DbAae570Chaknuul2024Context()) 
            {
                return context.Eventos.ToList();
            }
        }
    }
}
