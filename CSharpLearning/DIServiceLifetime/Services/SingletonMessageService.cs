namespace DIServiceLifetime.Services
{
    public class SingletonMessageService : ISingletonMessageService
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid GetId()
        {
            return _id;
        }
    }
}
