using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBfeeder.Models
{
    public class matches
    {
       
            public int matchid { get; set; }
            public int duration { get; set; }
            public int start_time { get; set; }
            public int radiant_team_id { get; set; }
            public string radiant_name { get; set; }
            public int dire_team_id { get; set; }
            public string dire_name { get; set; }
            public int leagueid { get; set; }
            public string league_name { get; set; }
            public int series_id { get; set; }
            public int series_type { get; set; }
            public int radiant_score { get; set; }
            public bool radiant_win { get; set; }
            public DateTime Datetime { get; set; }
            public bool processEntry { get; set; }
            //[Key]
            public int entry_id { get; set; }
        
    }
}