using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Newtonsoft.Json.Linq;

namespace Discord_bot_Tes
{
    class Program
    {
        public static Task Main(string[] args) => new Program().MainAsync();
        public static List<string> apis = new List<string>() {
        "#",
    };

        public static int api_index = 0;
        //public static string[] factions = { "9055"};
        public static string[] factions = {
      "20554",
      "25025",
      "10296",
      "35140",
      "25001",
      "8062",
      "13842",
      "13665",
      "15222",
      "22841",
      "9533",
      "21716",
      "27312",
      "9110",
      "11522",
      "43428",
      "9271",
      "11581",
      "15929",
      "231",
      "16628",
      "21687",
      "8677",
      "25335",
      "24693",
      "10979",
      "30009",
      "18678",
      "20881",
      "22295",
      "11376",
      "38847",
      "6538",
      "9953",
      "23188",
      "45507",
      "14441",
      "42505",
      "16634",
      "2095",
      "10624",
      "15083",
      "13131",
      "13737",
      "7935",
      "18597",
      "40959",
      "29865",
      "33241",
      "9055",
      "9405",
      "35965",
      "7227",
      "15837",
      "27266",
      "16057",
      "41768",
      "14820",
      "35776",
      "8510",
      "16247",
      "7115",
      "6974",
      "8152",
      "33007",
      "30584",
      "13851",
      "39616",
      "12863",
      "27370",
      "35280",
      "20514",
      "9041",
      "42435",
      "13343",
      "8400",
      "8076",
      "32395",
      "6834",
      "14052",
      "7093",
      "17250",
      "31312",
      "9171",
      "8520",
      "16335",
      "26154",
      "26437",
      "8766",
      "40449",
      "21239",
      "11539",
      "21526",
      "42168",
      "10913",
      "17845",
      "15154",
      "27902",
      "9176",
      "1149",
      "8181",
      "20303",
      "16503",
      "16424",
      "42650",
      "9356",
      "42671",
      "13180",
      "14581",
      "38063",
      "9357",
      "42125",
      "13129",
      "15046",
      "38761",
      "11747",
      "12645",
      "8811",
      "13274",
      "17133",
      "23193",
      "15595",
      "36891",
      "11356",
      "9745",
      "21665",
      "21234",
      "10818",
      "41067",
      "8509",
      "6780",
      "39788",
      "12255",
      "37595",
      "11131",
      "37450",
      "15930",
      "10850",
      "14078",
      "9280",
      "39756",
      "10820",
      "7197",
      "8205",
      "19",
      "946",
      "27223",
      "14768",
      "37132",
      "12249",
      "35090",
      "8500",
      "37131",
      "7986",
      "12912",
      "22680",
      "26043",
      "9100",
      "8803",
      "9689",
      "9032",
      "20747",
      "36134",
      "13307",
      "20501",
      "10856",
      "11559",
      "40775",
      "8795",
      "9524",
      "31764",
      "37093",
      "9412",
      "37530",
      "7049",
      "6799",
      "8317",
      "21040",
      "35423",
      "6541",
      "28349",
      "10566",
      "35831",
      "15151",
      "33097",
      "38668",
      "16040",
      "35840",
      "12894",
      "14686",
      "7002",
      "12094",
      "8566",
      "11428",
      "13726",
      "33458",
      "2013",
      "15602",
      "9036",
      "2736",
      "7680",
      "22781",
      "10174",
      "16053",
      "10877",
      "10739",
      "7282",
      "13784",
      "9420",
      "1117",
      "44762",
      "30085",
      "366",
      "20465",
      "6984",
      "11796",
      "8867",
      "7990",
      "8537",
      "7818",
      "18569",
      "10140",
      "10610",
      "46442",
      "16120",
      "89",
      "8606",
      "41853",
      "13789",
      "41238",
      "8989",
      "17776",
      "8954",
      "3241",
      "8085",
      "8819",
      "36691",
      "26885",
      "23952",
      "9047",
      "6895",
      "13383",
      "15644",
      "525",
      "8802",
      "8255",
      "12905",
      "7969",
      "18736",
      "28073",
      "6924",
      "15120",
      "8397",
      "33783",
      "35507",
      "11162",
      "28205",
      "27576",
      "230",
      "41419",
      "22887",
      "17001",
      "8392",
      "44758",
      "15286",
      "15655",
      "21069",
      "9674",
      "15446",
      "9201",
      "40399",
      "22932",
      "8384",
      "10960",
      "35739",
      "355",
      "8422",
      "9517",
      "10463",
      "14386",
      "937",
      "6731",
      "37185",
      "14365",
      "10741",
      "7835",
      "8836",
      "14760",
      "36140",
      "21028",
      "8322",
      "41929",
      "8285",
      "16282",
      "21368",
      "17587",
      "40420",
      "9166",
      "13377",
      "5431",
      "43325",
      "16187",
      "37786",
      "8585",
      "22492",
      "478",
      "9577",
      "15256",
      "44865",
      "27211",
      "30820",
      "2036",
      "7652",
      "16312",
      "8468",
      "8336",
      "32585",
      "40624",
      "13502",
      "37498",
      "36660",
      "10542",
      "25874",
      "14432",
      "9305",
      "12893",
      "9455",
      "26312",
      "8151",
      "30490",
      "16299",
      "8706",
      "8938",
      "8715",
      "40992",
      "41066",
      "7709",
      "95",
      "45151"
    };

        public static int minLAction = 3; // minutes
        public static float mugP = 7;
        public static int minMugValue = 4000000;
        public static int minBazaarValue = (int)Math.Round(minMugValue * 100 / mugP);
        public static Dictionary<string, long[]> playerData = new Dictionary<string, long[]>();
        public static Dictionary<string, string> playerCheckTime = new Dictionary<string, string>();
        public static string[] buyitems = {
      "106",
      "331",
      "330",
      "329",
      "370",
      "206",
      "366",
      "396",
      "985",
      "986",
      "987",
      "530",
      "553",
      "532",
      "554",
      "533",
      "555",
      "283",
      "818",
      "348",
      "681",
      "1308",
      "1309",
      "1307",
      "676",
      "670",
      "1311",
      "684",
      "671",
      "1310",
      "675",
      "679",
      "672",
      "677",
      "678",
      "644",
      "674",
      "673",
      "666",
      "667",
      "656"
    };
        public static string[] buyTypes = {
      "Plushie",
      "Flower"
    };
        public static string[] buyitemsXclude = {
      "903",
      "1034",
      "1032",
      "1033",
      "1031",
      "1030",
      "904",
      "901",
      "903",
      "902",
      "97",
      "129",
      "184",
      "183"
    };
        ulong channelID = #;
        ulong mugChannel = #;
        ulong buymugChannel = #;
        ulong zellobuymugchanelid = #;

       

        public static IMessageChannel channel;
        public static IMessageChannel channelMug;
        public static IMessageChannel buyMugChannel;
        public static IMessageChannel zelloBuyMugChannel;
        public static Dictionary<string, int> checkedPlayers = new Dictionary<string, int>();
        public static Dictionary<string, long> buymugchecked = new Dictionary<string, long>();
        public static IUserMessage sendMessageZello;
        public static IUserMessage sendMessageZelloMan;



        public static Dictionary<string, int> countryTimes = new Dictionary<string, int>() {
            {"Argentina", 167*60 },
            {"Canada", 41*60 },
            {"Islands", 35*60 },
            {"China", 242*60 },
            {"Hawaii", 134*60 },
            {"Japan", 225*60 },
            {"Mexico", 26*60 },
            {"Africa", 297*60 },
            {"Switzerland", 175*60 },
            {"UAE", 271*60 },
            {"Kingdom", 159*60 }
        };

        public static Dictionary<string, double> flightTypes = new Dictionary<string, double>() {
            {"standard", 1},
            {"airstrip", 0.7 },
            {"private", 0.5 },
            {"business", 0.3 } 
        };






        public static List<string> checked_api = new List<string>();

        public static Dictionary<string, List<String>> playerInformation = new Dictionary<string, List<string>>();

        public static int memberIndex = 0;

        public static Dictionary<string, Dictionary<string, long>> mugValues = new Dictionary<string, Dictionary<string, long>>();

        public static List<string> playerKeys;

        public static Dictionary<string, int> travelTime = new Dictionary<string, int>();

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());

            return Task.CompletedTask;
        }
        public static DiscordSocketClient _client;

        public async Task MainAsync()
        {
            var config = new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.GuildMessages
            };

            _client = new DiscordSocketClient(config);

            _client.Log += Log;

            //  You can assign your bot token to a string, and pass that in to connect.
            //  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.
            var token = "#";

            // Some alternative options would be to keep your token in an Environment Variable or a standalone file.
            // var token = Environment.GetEnvironmentVariable("NameOfYourEnvironmentVariable");
            // var token = File.ReadAllText("token.txt");
            // var token = JsonConvert.DeserializeObject<AConfigurationClass>(File.ReadAllText("config.json")).Token;

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            channel = await _client.GetChannelAsync(channelID) as IMessageChannel;
            channelMug = await _client.GetChannelAsync(mugChannel) as IMessageChannel;
            buyMugChannel = await _client.GetChannelAsync(buymugChannel) as IMessageChannel;
            zelloBuyMugChannel = await _client.GetChannelAsync(zellobuymugchanelid) as IMessageChannel;

          

            //   await channel.SendMessageAsync("Start");
            //   await channelMug.SendMessageAsync("Start");

            Thread factionThread = new Thread(checkFactions)
            {
                IsBackground = true
            };
            Thread playerThread = new Thread(checkAllPlayers)
            {
                IsBackground = true
            };

            await checkAPI();

            factionThread.Start();
            playerThread.Start();

            //await postPlayer("2669774", 123456789);

            //await GetData();

            // Block this task until the program is closed.
            await Task.Delay(-1);

        }

        public static async void checkFactions()
        {
            while (true)
            {
                Console.WriteLine("Checking + " + playerData.Keys.Count + " Players");
                await GetData();

                Thread.Sleep(TimeSpan.FromMinutes(5));

            }

        }

        public static async void checkAllPlayers()
        {
            try
            {
                await checkPlayers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                await checkPlayers();

            }

        }

        public static async Task GetData()
        {
            using (HttpClient client = new HttpClient())
            {
                foreach (string faction in factions)
                {
                    try
                    {
                        string curr_api = getApi();
                        HttpResponseMessage response = await client.GetAsync("https://api.torn.com/faction/" + faction + "?selections=basic&key=" + curr_api + "&comment=Zello");
                        response.EnsureSuccessStatusCode();
                        string resData = await response.Content.ReadAsStringAsync();

                        //Dictionary<string, string> jdata = JsonSerializer.Deserialize<Dictionary<string, string>>(resData);
                        JObject jsdata = JObject.Parse(resData);
                        Console.WriteLine("Checking faction: " + faction);
                        if (jsdata["error"] != null)
                        {
                            Console.WriteLine("Error with key: " + curr_api);
                            apis.Remove(curr_api);
                            continue;
                        }

                        JObject members = (JObject)jsdata["members"];
                        var keys = members.Properties().Select(p => p.Name);
                        foreach (var member in keys)
                        {
                            string lastactime = (string)members[member]["last_action"]["timestamp"];
                            int lastactimestamp = Int32.Parse(lastactime);

                            if (checkedPlayers.ContainsKey(member))
                            {
                                if (checkedPlayers[member] == lastactimestamp)
                                {
                                    continue;
                                }
                            }

                            string lastAction = (string)members[member]["last_action"]["relative"];
                            string curStatus = (string)members[member]["last_action"]["status"];

                            //Console.WriteLine(lastAction);

                            long[] bazaarValue;

                            if (!curStatus.Contains("Online"))
                            {
                                if (lastAction.Contains("minute"))
                                {
                                    string[] lAction = lastAction.Split(' ');
                                    int lMinute = Int16.Parse(lAction[0]);
                                    if (lMinute < minLAction)
                                    {
                                        continue;
                                    }
                                }
                                int no_of_tries = 1;
                                try
                                {
                                    bazaarValue = await calculateValue(member);
                                }
                                catch (Exception ex)
                                {
                                    no_of_tries++;
                                    Console.WriteLine(ex.Message);
                                    if (no_of_tries > 5)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        bazaarValue = await calculateValue(member);
                                    }
                                }

                                if (bazaarValue[0] > minBazaarValue)
                                {
                                    playerData[member] = bazaarValue;
                                    playerCheckTime[member] = DateTime.UtcNow.ToString("h:mm:ss tt");
                                }   

                            }

                            checkedPlayers[member] = lastactimestamp;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Stack Trace: ");
                        Console.WriteLine(ex.StackTrace);
                        //Thread.Sleep(TimeSpan.FromSeconds(1));
                        continue;
                    }

                }

            }
            //Console.ReadKey();
        }

        //public static string getNextMember()
        //{

        //    if (playerData.Keys.Count == 0)
        //    {
        //        return "";
        //    }
        //    memberIndex++;
        //    memberIndex %= playerData.Keys.Count;

        //    playerKeys = new List<string>(playerData.Keys);

        //    return playerKeys[memberIndex];

        //}

        public static async Task checkPlayers()
        {

            while (true)
            {
                

                try
                {
                    Dictionary<string, long[]> playerDCopy = new Dictionary<string, long[]>(playerData);
                    foreach (string member in playerDCopy.Keys)
                    {

                        //string member = getNextMember();

                        //if (member == "")
                        //{
                        //    continue;
                        //}

                        long[] newValue = await calculateValue(member);

                        // {value, no of items, color, clothing store, last action, state}


                        long[] currentValue = playerData[member];
                        long diff = currentValue[0] - newValue[0];

                        long potentialMug = (long)Math.Round(diff * (mugP / 100));

                        if (newValue[3] == 1)
                        {
                            potentialMug = (long)Math.Round(potentialMug * 0.25);
                        }


                        if (newValue[0] == 0 || newValue[1] == 0)
                        {
                            playerData.Remove(member);

                            continue;
                        }

                        if (potentialMug > minMugValue && newValue[1] < currentValue[1] && newValue[4] == 1 && newValue[5] == 1)
                        {
                            await postPlayer(member, potentialMug, currValue: newValue, color: newValue[2]);
                        }

                        if (newValue[0] < minBazaarValue)
                        {
                            if (playerData.ContainsKey(member))
                            {
                                playerData.Remove(member);
                            }
                        }

                        playerData[member] = newValue;
                        playerCheckTime[member] = DateTime.UtcNow.ToString("h:mm:ss tt");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Stack Trace: ");
                    Console.WriteLine(ex.StackTrace);
                    //Thread.Sleep(TimeSpan.FromSeconds(1));
                    continue;
                }

            }
        }

        public static async Task checkAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                List<String> apiCopy = new List<string>(apis);
                foreach (string api in apiCopy)
                {
                    HttpResponseMessage response = await client.GetAsync("https://api.torn.com/user/?selections=basic&key=" + api + "&comment=Zello");
                    response.EnsureSuccessStatusCode();
                    string resp = await response.Content.ReadAsStringAsync();
                    var respJ = JObject.Parse(resp);

                    if (respJ["error"] != null)
                    {
                        Console.WriteLine("Error with key: " + api + " " + respJ["error"]);
                        apis.Remove(api);
                    }
                    else
                    {
                        Console.WriteLine("API Working for: " + respJ["name"]);
                        if (checked_api.Contains((string)respJ["name"]))
                        {
                            Console.WriteLine("Duplicate Key: " + api + " Name: " + respJ["name"]);
                            apis.Remove(api);
                        }
                        else
                        {
                            checked_api.Add((string)respJ["name"]);
                        }
                    }

                }
                Console.WriteLine("API Check Complete!");

            }

        }

        public static async Task postPlayer(string id, long pmug, long[] currValue = null, bool buyM = false, string buyD = "", long color = 0)
        {


            Color col = Color.Green;
            string traveltimetext = "\n";
            

            
                if (color == 2)
                {
                    col = Color.Blue;
                string[] tcountry = playerInformation[id][4].Split(' ');
                string country = tcountry[tcountry.Length - 1];

                if (travelTime.ContainsKey(id)) {
                    if (countryTimes.ContainsKey(country))
                    {
                        foreach (string fltype in flightTypes.Keys)
                        {
                            int ptime = (int)Math.Round(countryTimes[country] * flightTypes[fltype]);
                            int landingTime = travelTime[id] + ptime;
                            DateTimeOffset landTime = DateTimeOffset.FromUnixTimeSeconds(landingTime);
                            string landTimeString = landTime.ToString();

                            traveltimetext += landTimeString + " : " + fltype + "\n";
                        }
                    }
                }

                


                }
                else if (color == 1)
                {
                    col = Color.Red;
                }

                

                string pData = "";
                if (playerData.ContainsKey(id))
                {
                    pData = playerData[id][0].ToString("N0");
                }

                string lcheck = "";

                if (playerCheckTime.ContainsKey(id))
                {
                    lcheck = playerCheckTime[id];
                }

               

                string fpmug = pmug.ToString("N0");

                if (buyM)
                {
                if (color == 0)
                {
                    col = Color.Purple;
                    fpmug += " BUYMUG!";
                }
                else {
                    return;
                }
                        
                    
                }

                

                string mention = "";
                if (pmug > 10000000)
                {
                    mention = "<@198715108032118784>";
                }

                
                long[] checkValue;

                if (!buyM && pmug > 30000000)
                {
                    checkValue = await calculateValue(id);
                    if (checkValue[0] == 0 || checkValue[1] == 0)
                    {
                        return;
                    }
                    if (currValue != null && checkValue[0] > currValue[0])
                    {
                        return;
                    }
                    if (currValue != null && checkValue[1] > currValue[1])
                    {
                        return;
                    }
                }
                EmbedBuilder embeda;
                if (buyM)
                {
                // name, level, lastactionrelative, statusdetails
                embeda = new EmbedBuilder()
                    {
                        Title = fpmug,
                        Description = "Name : " + playerInformation[id][0] + "\n" +
                        "Level: " + playerInformation[id][1] + "\n" +
                        "Status: " + playerInformation[id][3] + "\n" +
                        "Last Action: " + playerInformation[id][2] + "\n" +
                        "Attack Link: https://www.torn.com/loader.php?sid=attack&user2ID=" + id + "\n" +
                        "Profile Link: https://www.torn.com/profiles.php?XID=" + id + "\n" +
                        "Bazaar Link: https://www.torn.com/bazaar.php?userId=" + id + buyD,
                        Color = col
                    };
                }
                else
                {
                    embeda = new EmbedBuilder()
                    {
                        Title = fpmug + " " ,
                        Description = "Name : " + playerInformation[id][0] + "\n" +
                        "Level: " + playerInformation[id][1] + "\n" +
                        "Status: " + playerInformation[id][3] + "\n" +
                        "Last Action: " + playerInformation[id][2] + "\n" +
                        "Attack Link: https://www.torn.com/loader.php?sid=attack&user2ID=" + id + "\n" +
                        "Profile Link: https://www.torn.com/profiles.php?XID=" + id + "\n" +
                        "Last Checked Value: " + pData + "\n" +
                        "Last Check Time: " + lcheck + "\n" +
                        "Previous Item Quantity: " + playerData[id][1].ToString("N0") + "\n" +
                        "Current Value: " + currValue[0].ToString("N0") + "\n" +
                        "Current Item Quantity: " + currValue[1].ToString("N0") + "\n" +
                        "Current Time: " + DateTime.UtcNow.ToString("h:mm:ss tt") + "\n" +
                        "Bazaar Link: https://www.torn.com/bazaar.php?userId=" + id + buyD + "\n" +
                        traveltimetext,
                        Color = col
                    };
                }

                if (buyM)
                {
                    await zelloBuyMugChannel.SendMessageAsync(mention, false, embeda.Build());
                    await buyMugChannel.SendMessageAsync("", false, embeda.Build());
                   
            }
                else
                {

                    await channel.SendMessageAsync(mention, false, embeda.Build());
                    await channelMug.SendMessageAsync("", false, embeda.Build());
                    

            }

            
        }

        public static async Task<long[]> calculateValue(string id)
        {
            try
            {
                long value = 0;
                long no_of_items = 0;

                using (HttpClient client = new HttpClient())
                {
                    string curr_api = getApi();
                    HttpResponseMessage bazaarData = await client.GetAsync("https://api.torn.com/user/" + id + "?selections=profile,bazaar&key=" + getApi());
                    bazaarData.EnsureSuccessStatusCode();
                    string bazDaString = await bazaarData.Content.ReadAsStringAsync();
                    var bdata = JObject.Parse(bazDaString);
                    if (bdata["error"] != null)
                    {
                        Console.WriteLine("Error with key: " + curr_api);
                        apis.Remove(curr_api);
                        return new long[] {
              0,
              0
            };

                    }
                    string traveling = (string)bdata["status"]["description"];
                    string travelingstatus = (string)bdata["status"]["state"];
                    if (playerInformation.ContainsKey(id)) {
                        if (playerInformation[id][3] != "Traveling")
                        {
                            if (travelingstatus == "Traveling")
                            {
                                travelTime[id] = Int32.Parse((string)bdata["last_action"]["timestamp"]);
                            }
                            else {
                                if (travelTime.ContainsKey(id)) {
                                    travelTime.Remove(id);

                                }
                            }
                        }
                        else {
                            if (travelingstatus == "Traveling" && traveling != playerInformation[id][4]) {
                                travelTime[id] = Int32.Parse((string)bdata["last_action"]["timestamp"]);
                            }
                        }

                    }




                    playerInformation[id] = new List<string>() {(string)bdata["name"], (string)bdata["level"], (string)bdata["last_action"]["relative"], (string)bdata["status"]["state"], (string)bdata["status"]["description"]};
                    // name, level, lastactionrelative, statusdetails, statusDescription

                    

                    

                    long buyMugVal = 0;
                    string buyMugItems = "\n + Items: \n";
                    string statusOk;
                    long statusk = 1;

                    long color = 0;

                    statusOk = (string)bdata["status"]["state"];
                    string okayReason = (string)bdata["status"]["details"];
                    okayReason = okayReason.Split(' ')[0];
                    if (statusOk == "Hospital")
                    {
                        color = 1;
                        if (okayReason != "Mugged")
                        {
                            statusk = 0;
                        }
                    }
                    else if (statusOk == "Traveling") {
                        color = 2;
                    }

                    int company_type = Int16.Parse((string)bdata["job"]["company_type"]);

                    long clothing = 0;
                    Double buyMultiplier = 1;
                    if (company_type == 5) {
                        clothing = 1;
                        buyMultiplier = 0.25;
                    }

                    
                    string lastAction = (string)bdata["last_action"]["relative"];
                    long lA = 0;

                    
                        if (lastAction.Contains("minute"))
                        {
                            string[] lAction = lastAction.Split(' ');
                            int lMinute = Int16.Parse(lAction[0]);
                            if (lMinute >= 2)
                            {
                                lA = 1;
                            }
                        }
                        else
                        {
                            lA = 1;
                        }

                    

                    



                    if (bdata.ContainsKey("bazaar"))
                    {
                        foreach (var data in bdata["bazaar"])
                        {
                            long market_price = (long)data["price"];
                            if (market_price <= 1)
                            {
                                continue;
                            }
                            int quantity = (int)data["quantity"];
                            long market_value = (long)data["market_price"];
                            string itemType = (string)data["type"];
                            string itemName = (string)data["name"];
                            string itemId = (string)data["ID"];

                            if (itemType != "Defensive" && itemType != "Secondary" && itemType != "Primary" && itemType != "Melee")
                            {
                                if ((0.93 * market_price) < market_value)
                                {
                                    if (!buyitemsXclude.Contains(itemId) && (buyTypes.Contains(itemType) || buyitems.Contains(itemId)))
                                    {
                                        buyMugVal += (int)Math.Round((market_value - (0.93 * market_price)) * quantity * buyMultiplier);
                                        buyMugItems += "I: " + itemName + " P: " + market_price.ToString("N0") + " V: " + market_value.ToString("N0") + " Q: " + quantity.ToString("N0") + "\n";

                                    }
                                    //Console.WriteLine(0.93 * market_price);
                                }
                            }

                            if (market_price <= (1.05 * market_value) && market_price >= (0.5 * market_value))
                            {
                                value += market_price * quantity;
                                no_of_items += quantity;
                            }

                        }
                    }
                    

                    if (buyMugVal > minMugValue)
                    {
                        if (buymugchecked.ContainsKey(id))
                        {
                            if (buymugchecked[id] * 0.9 >= buyMugVal || buyMugVal >= 1.1 * buymugchecked[id])
                            {
                                buymugchecked[id] = buyMugVal;
                                await postPlayer(id, buyMugVal, buyM: true, buyD: buyMugItems, color: color);
                            }

                        }
                        else
                        {
                            buymugchecked[id] = buyMugVal;
                            await postPlayer(id, buyMugVal, buyM: true, buyD: buyMugItems, color: color);
                        }

                    }

                    long[] val_no = {
            value,
            no_of_items,
            color,
            clothing,
            lA,
            statusk
          };

                    // {value, no of items, color, clothing store, last action, state}
                    return val_no;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Checking " + id);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stack Trace: ");
                Console.WriteLine(ex.StackTrace);
                if (playerData.ContainsKey(id))
                {
                    return playerData[id];
                }
                return new long[] {
          0,
          0
        };
            }

        }

        public static string getApi()
        {
            api_index++;
            if (api_index >= apis.Count)
            {
                api_index = 0;
            }
            return apis[api_index];

        }

    }
}