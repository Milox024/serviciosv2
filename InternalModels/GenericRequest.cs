namespace chaknuul_services.InternalModels
{
    public class GenericRequest<T>
    {
        public string Referencia { get; set; }
        public T Data { get; set; }
    }
}
