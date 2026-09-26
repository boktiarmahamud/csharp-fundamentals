namespace DIServiceLifetime.Services
{
    public class ScopedMessageService : IScopedMessageService
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid GetId()
        {
            return _id;
        }
    }
    
}
