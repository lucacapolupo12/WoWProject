using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace WoW;


public class Data
{
    public JsonObject data { get; set; }
}

public class JsonClass
{
    //public int Last_battle_time { get; set; }
    [JsonPropertyName("account_id")]
    public int account_id { get; set; }
    [JsonPropertyName("statistics")]
    public Statistics statistics { get; set; } = new Statistics();
    [JsonPropertyName("stats_updated_at")]
    public int stats_updated_at { get; set; }
}

public class Aircraft
{
    public int frags { get; set; }
}
public class MainBattery
{
    public int frags { get; set; }
    public int hits { get; set; }
    public int shots { get; set; }
}
public class Pvp
{
    //public int damage_to_buildings { get; set; }
    public MainBattery main_battery { get; set; } = new MainBattery();
    public int art_agro { get; set; }
    public int ships_spotted { get; set; }
    public SecondBattery second_battery { get; set; } = new SecondBattery(); 
    public int survived_battles { get; set; }
    //public int dropped_capture_points { get; set; }
    public int torpedo_agro { get; set; }
    //public int draws { get; set; }
    public int control_captured_points { get; set; }
    public int planes_killed { get; set; }
    //public int battles { get; set; }
    public int survived_wins { get; set; }
    public int frags { get; set; }
    public int damage_scouting { get; set; }
    public int capture_points { get; set; }
    public Ramming ramming { get; set; } = new Ramming();
    public int suppressions_count { get; set; }
    public Torpedoes torpedoes { get; set; } = new Torpedoes();
    public Aircraft aircraft { get; set; } = new Aircraft();
    public int team_capture_points { get; set; }
    public int control_dropped_points { get; set; }
    public int wins { get; set; }
    public int losses { get; set; }
    public int team_dropped_capture_points { get; set; }
}

public class Ramming
{
    public int frags { get; set; }
}
public class SecondBattery
{
    public int frags { get; set; }
    public int hits { get; set; }
    public int shots { get; set; }
}

public class Statistics
{
    public int distance { get; set; }
    public int battles { get; set; }
    public Pvp pvp { get; set; } = new Pvp();
}

public class Torpedoes
{
    public int frags { get; set; }
    public int hits { get; set; }
    public int shots { get; set; }
}
