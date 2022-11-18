using System;
using System.Collections.Generic;

#nullable disable

namespace Task3.Models
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
