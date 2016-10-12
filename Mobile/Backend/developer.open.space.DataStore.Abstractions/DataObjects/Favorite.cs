﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace developer.open.space.DataStore.Abstractions.DataObjects
{
    public class Favorite : BaseDataObject
    {
        public string UserId { get; set; }
        public string SessionId { get; set; }
        public string WorkshopId { get; set; }
    }
}
