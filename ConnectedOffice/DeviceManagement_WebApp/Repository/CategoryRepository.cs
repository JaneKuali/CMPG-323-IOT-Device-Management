using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }
    }
}
