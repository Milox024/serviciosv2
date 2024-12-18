namespace chaknuul_services.Business
{
    public class LoginBS
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
    }
}
