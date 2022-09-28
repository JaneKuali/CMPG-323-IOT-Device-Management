using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;

namespace DeviceManagement_WebApp.Repository
{
    public class DevicesRepository : GenericRepository<Device>, IDevicesRepository
    {
        public DevicesRepository(ConnectedOfficeContext context) : base(context)
        {
        }
    }
}
