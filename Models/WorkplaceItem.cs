﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Task3.Models
{
    public partial class WorkplaceItem
    {
        public int ItemId { get; set; }
        public int WorkplaceId { get; set; }
        public int Count { get; set; }

        public virtual Item Item { get; set; }
        public virtual Workplace Workplace { get; set; }
    }
}
