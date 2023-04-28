﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coven.Logic.Request_Models.Get
{
    public class WorldAnvilWorld
    {
        public Guid id { get; set; }
        public string username { get; set; }
        public List<WorldMeta> worlds { get; set; }
    }
    public class WorldMeta
    {
        public Guid id { get; set; }
        public string state { get; set; }
        public string name { get; set; }
    }
}
