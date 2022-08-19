using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace userInterfaceTutorial
{
    //(K/D+assists+firstKills+((oppeningDuels+HS)*2))/(FirstKill+KD+((HS+OpnDuels)*2)+Assist+K/D)

    public partial class csgoStatsForm : Form
    {
        readonly string location = "D:\\Sivaguru\\Programming\\C#\\UI Ux\\userInterfaceTutorial\\userInterfaceTutorial\\Data\\";
        string key = "155E26AAB97BFEAD2F24F1207B55A603";
        private string ReadID()
        {
            StreamReader idReader = new StreamReader(location + "id.txt");
            string id = idReader.ReadToEnd();
            idReader.Close();
            return id;
        }
        public csgoStatsForm()
        {
            InitializeComponent();
        }

        private void csgoStatsForm_Load(object sender, EventArgs e)
        {
            PublishData();
        }

        private dynamic ReadLocalData()
        {
            try
            {
                StreamReader CSGOdataReader = new StreamReader(location + "CSGOStatsData.json");
                dynamic data = CSGOdataReader.ReadToEnd();
                CSGOdataReader.Close();
                data = JsonConvert.DeserializeObject<dynamic>(data);
                
                return data;
            }
            catch (Exception) { return "";}
        }
        private dynamic GetSchema()
        {
            //Read Schema File
            StreamReader schemaReader = new StreamReader(location + "CSGOStatsSchemaData.json");
            string json = schemaReader.ReadToEnd();
            dynamic schemaData = JsonConvert.DeserializeObject(json);
            schemaReader.Close();
            return schemaData;
        }

        private dynamic SchemaUpdateStats(dynamic schemaData)
        {
            dynamic schemaStats = schemaData["game"]["availableGameStats"]["stats"];
            //Create schema Stats Dictionary and add values
            Dictionary<string, string> schemaStatsDictionary = new Dictionary<string, string>();
            foreach (var i in schemaStats)
            {
                string name = i["name"];
                string value = i["defaultvalue"];
                schemaStatsDictionary.Add(name, value);
            }
            var localUserStats = ReadLocalData();
            try
            {
                dynamic StatsData = localUserStats["playerstats"]["stats"];

                //Update user stats data into schema stats dictionary
                foreach (var i in StatsData)
                {
                    string name = i["name"];
                    string value = i["value"];
                    schemaStatsDictionary[name] = value;
                }
                return schemaStatsDictionary;
            }

            catch{ return schemaStatsDictionary;}
            
        }

        private dynamic SchemaUpdateAcievements(dynamic schemaData)
        {
            dynamic schemaAchievements = schemaData["game"]["availableGameStats"]["achievements"];
            //Create schema achievements Dictionary and add values
            Dictionary<String, string> schemaAchievementsDictionary = new Dictionary<string, string>();
            foreach (var i in schemaAchievements)
            {
                string name = i["name"];
                string value = i["defaultvalue"];
                schemaAchievementsDictionary.Add(name, value);
            }
            var localUserAchievements = ReadLocalData();
            try
            {
                dynamic achievemendsData = localUserAchievements["playerstats"]["achievements"];

                //Update user achievements Data into schema achievements Dictionary
                foreach (var i in achievemendsData)
                {
                    string name = i["name"];
                    string value = i["achieved"];
                    schemaAchievementsDictionary[name] = value;
                }
                return schemaAchievementsDictionary;
            }
            catch { return schemaAchievementsDictionary;}
        }
            

        private void PublishData()
        {
            string total_kills = "0";
            string total_deaths = "0";
            double kdRatio = 0;
            var csgoStatsData = SchemaUpdateStats(GetSchema());
            var csgoAchievementsData = SchemaUpdateAcievements(GetSchema());

            //Display Stats
           
            total_kills = csgoStatsData["total_kills"];
            totalKillsLabel.Text = "Total Kills: " + total_kills;

            total_deaths = csgoStatsData["total_deaths"];
            totalDeathsLabel.Text = "Total Deaths: " + total_deaths;

            kdRatio = double.Parse(total_kills) / double.Parse(total_deaths);
            kdRatio = Math.Round(kdRatio, 2);
            kdDisplayValueLabel.Text = kdRatio.ToString();
            try { kdBar.Value = Convert.ToInt16(kdRatio * 100);}
            catch { kdBar.Value = 0;}
        }

        private void GetWebData(string id)
        {
            try
            {
                var client = new WebClient();
                var data = client.DownloadString("https://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid=730&key=" + key + "&steamid=" + id);
                WriteLocalData(data);
            }
            catch (Exception)
            { 
                WriteLocalData("");
            }
        }
        private void WriteLocalData(string data)
        {
            StreamWriter sw1 = new StreamWriter(location + "CSGOStatsData.json");
            sw1.WriteLine(data);
            sw1.Close();
        }

        private void csgoStatsForm_MouseEnter(object sender, EventArgs e)
        {
            string id = ReadID();
            IDLabel.Text = id;
        }

        private void IDLabel_TextChanged(object sender, EventArgs e)
        {
            GetWebData(ReadID());
            csgoStatsForm_Load(sender, e);
        }
    }
}
