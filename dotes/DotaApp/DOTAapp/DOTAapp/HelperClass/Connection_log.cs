﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBstatsAnalysis.HelpClasses
{
    public class Connection_log
    {
        public int time { get; set; }
        public string @event { get; set; }
        public int player_slot { get; set; }
    }
}