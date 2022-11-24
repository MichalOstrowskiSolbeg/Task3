using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DbModels;

namespace Task3.Repositories
{
    public class WorkplaceRepository : IWorkplaceRepository
    {
        private readonly MyDbContext _context;
        public WorkplaceRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<Workplace> GetWorkplaces()
        {
            return _context.Workplaces.ToList();
        }
    }
}