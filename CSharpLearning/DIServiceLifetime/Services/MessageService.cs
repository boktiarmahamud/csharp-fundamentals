using System.Runtime.CompilerServices;
namespace DIServiceLifetime.Services
{
    public class MessageService : IMessageService
    {
        private readonly Guid _id = Guid.NewGuid();

        public Guid GetId()
        {
            return _id;
        }
    }
}
