using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;
using System;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }
    }
}
