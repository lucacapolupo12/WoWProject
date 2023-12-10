using System.Text.Json;
using System.Text.Json.Serialization;
using WoW;

HttpClient client = new HttpClient();

var playerList = new List<int> { 
#region Id List
    500004385,
    500211302,
    500241459,
    500392101,
    500925375,
    501529911,
    504551798,
    505068797,
    505091344,
    509987509,
    511533697,
    512159521,
    512738038,
    512941313,
    515240356,
    515674300,
    517713114,
    518905240,
    521918010,
    523642292,
    526549800,
    528473841,
    528832776,
    528927747,
    529400802,
    530145684,
    530371216,
    530886282,
    531259858,
    533573166,
    539959341,
    541819903,
    550498634,
    551869913,
    552848683,
    553207383,
    559266380,
    562913374,
    563018269,
    564409769,
    568676680,
    568713282,
    569690009,
    571675320,
    575214009,
    578060406,
    578887227,
    590530885,
    603413227,
    673416937
    #endregion
};

var itemList = new List<Data>();

foreach (var player in playerList)
{
    using HttpResponseMessage response = await client.GetAsync($"https://api.worldofwarships.eu/wows/account/info/?application_id=de2e01e9d75083cd047d13111ef03c18&account_id={player}");
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();

    var item = JsonSerializer.Deserialize<Data>(responseBody);
    itemList.Add(item);
    await Task.Delay(1000);

    Console.WriteLine(player + " " + response.StatusCode);
}

