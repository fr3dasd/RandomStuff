using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBstatsAnalysis.HelpClasses
{
    public class Players
    {

        public int match_id { get; set; }
        public int player_slot { get; set; }
        public int[] ability_upgrades_arr { get; set; }
        public object ability_uses { get; set; }
        public object ability_targets { get; set; }
        public int account_id { get; set; }
        public object actions { get; set; }
        public object additional_units { get; set; }
        public int assist { get; set; }
        public int backpack_0 { get; set; }
        public int backpack_1 { get; set; }
        public int backpack_2 { get; set; }
        public Buyback_log[] BuyBack_log { get; set; }
        public int camp_stacked { get; set; }
        public Connection_log[] Connection_log { get; set; }
        public int creeps_stacked { get; set; }
        public object damage { get; set; }
        public object damage_inflictor { get; set; }
        public object damage_inflictor_received { get; set; }
        public object damage_taken { get; set; }
        public int deaths { get; set; }
        public int denies { get; set; }
        public int[] dn_t { get; set; }
        public int gold { get; set; }
        public int gold_per_min { get; set; }
        public object gold_reasons { get; set; }
        public int gold_spent { get; set; }
        public int[] gold_t { get; set; }
        public int hero_damage { get; set; }
        public int hero_healing { get; set; }
        public object hero_hits { get; set; }
        public int hero_id { get; set; }
        public int item_0 { get; set; }
        public int item_1 { get; set; }
        public int item_2 { get; set; }
        public int item_3 { get; set; }
        public int item_4 { get; set; }
        public int item_5 { get; set; }
        public object item_uses { get; set; }
        public object kill_streaks { get; set; }
        public object killed { get; set; }
        public object killed_by { get; set; }
        public int kills { get; set; }
        public Kills_log[] kills_log { get; set; }
        public object lane_pos { get; set; }
        public int last_hits { get; set; }
        public int leaver_status { get; set; }
        public int level { get; set; }
        public int[] lh_t { get; set; }
        public object life_state { get; set; }
        public object max_hero_hit { get; set; }
        public object multi_kills { get; set; }
        public object obs { get; set; }
        public object[] obs_left_log { get; set; }
        public object[] obs_log { get; set; }
        public int obs_placed { get; set; }
        public int party_id { get; set; }
        public object[] permanent_buffs { get; set; }
        public int pings { get; set; }
        public object purchase { get; set; }
        public Purchases[] purchases_log { get; set; }
        public int rune_pickups { get; set; }
        public Runes runes { get; set; }
        public RunesLog[] runes_log { get; set; }
        public object sen { get; set; }
        public object[] sen_left_log { get; set; }
        public object[] sen_log { get; set; }
        public int sen_placed { get; set; }
        public int stuns { get; set; }
        public int[] times { get; set; }
        public int tower_damage { get; set; }
        public int xp_per_min { get; set; }
        public object xp_reasons { get; set; }
        public int[] xp_t { get; set; }
        public string personaname { get; set; }
        public string name { get; set; }
        public int last_login { get; set; }
        public bool radiant_win { get; set; }
        public int start_time { get; set; }
        public int duration { get; set; }
        public int cluster { get; set; }
        public int lobby_type { get; set; }
        public int game_mode { get; set; }
        public int patch { get; set; }
        public int region { get; set; }
        public int isRadiant { get; set; }
        public int win { get; set; }
        public int lose { get; set; }
        public int total_gold { get; set; }
        public int total_xp { get; set; }
        public int kills_per_min { get; set; }
        public int kda { get; set; }
        public int abandons { get; set; }
        public int neutral_kills { get; set; }
        public int tower_kills { get; set; }
        public int courier_kils { get; set; }
        public int lane_kills { get; set; }
        public int hero_kills { get; set; }
        public int observer_kills { get; set; }
        public int sentry_kills { get; set; }
        public int roshan_kills { get; set; }
        public int necronomicon_kills { get; set; }
        public int ancient_kills { get; set; }
        public int buyback_count { get; set; }
        public int observer_uses { get; set; }
        public int sentry_uses { get; set; }
        public int lane_efficiency { get; set; }
        public int lane_efficiency_pct { get; set; }
        public int lane { get; set; }
        public int lane_role { get; set; }
        public bool is_roaming { get; set; }
        public object purchase_time { get; set; }
        public object first_purchase_time { get; set; }
        public object item_win { get; set; }
        public object item_usage { get; set; }
        public object purchase_tpscroll { get; set; }
        public int actions_per_min { get; set; }
        public int life_state_dead { get; set; }
        public int rank_tier { get; set; }
        public int[] cosmetics { get; set; }
        public object benchmarks { get; set; }
        









    }
}