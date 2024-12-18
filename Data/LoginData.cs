namespace chaknuul_services.Data
{
    public class LoginData
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
    }
}
