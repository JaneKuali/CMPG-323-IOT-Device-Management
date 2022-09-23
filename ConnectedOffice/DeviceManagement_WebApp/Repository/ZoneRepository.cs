using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }
    }
}
