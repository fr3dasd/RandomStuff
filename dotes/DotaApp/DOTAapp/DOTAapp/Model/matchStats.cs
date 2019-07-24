using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBstatsAnalysis.HelpClasses;

namespace DBstatsAnalysis.Models
{
    public class matchStats
    {
        
        //[Key]
        public int match_id { get; set; }
        public int barracks_status_dire { get; set; }
        public int barracks_status_radiant { get; set; }
        public Chat[] chat { get; set; }
        public int cluster { get; set; }
        public object cosmetics { get; set; }
        public int dire_score { get; set; }
        public DraftTimings[] draft_timings { get; set; }
        public int duration { get; set; }
        public int engine { get; set; }
        public int first_blood_time { get; set; }
        public int game_mode { get; set; }
        public int human_players { get; set; }
        public int leagueid { get; set; }
        public int lobby_type { get; set; }
        public int match_seq_num { get; set; }
        public int negative_votes { get; set; }
        public object objectives { get; set; }
        public object picks_bans { get; set; }
        public int positive_votes { get; set; }
        public object radiant_gold_adv { get; set; }
        public int radiant_score { get; set; }
        public bool radiant_win { get; set; }
        public object radiant_xp_adv { get; set; }
        public int start_time { get; set; }
        public object teamfights { get; set; }
        public int tower_status_dire { get; set; }
        public int tower_status_radiant { get; set; }
        public int version { get; set; }
        public int replay_salt { get; set; }
        public int series_id { get; set; }
        public int series_type { get; set; }
        public object radiant_team { get; set; }
        public object dire_team { get; set; }
        public object league { get; set; }
        public int skill { get; set; }
        public Players[] player { get; set; }
        public int patch { get; set; }
        public int region { get; set; }
        public object all_word_counts { get; set; }
        public object my_word_counts { get; set; }
        public int @throw { get; set; }
        public int comeback { get; set; }
        public int loss { get; set; }
        public int win { get; set; }
        public string replay_url { get; set; }

    }
}



