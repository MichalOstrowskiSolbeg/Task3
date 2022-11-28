using RepositoryLayer.DbModels;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly MyDbContext _context;
        public ItemRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<Item> GetItems()
        {
            return _context.Items.ToList();
        }
    }
}