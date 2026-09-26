using Minimal_APIs.Models;

namespace Minimal_APIs.Data
{
    public class CuponStore
    {
        public static List<Cupon> cuponList = new List<Cupon>
        {
            new Cupon{Id = 1, Name = "100F", Percent = 10, IsActive = true },
            new Cupon{Id = 2, Name = "200F", Percent = 10, IsActive = true}
        };
    }
}
