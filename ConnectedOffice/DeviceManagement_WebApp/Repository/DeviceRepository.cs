using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }
    }
}
