using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryLayer.DbModels
{
    public partial class Item
    {
        public Item()
        {
            WorkplaceItems = new HashSet<WorkplaceItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WorkplaceItem> WorkplaceItems { get; set; }
    }
}
