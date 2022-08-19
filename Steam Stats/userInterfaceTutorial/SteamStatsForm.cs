using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;

//Karthik - 76561198399289219
//Preetam - 76561198362605034
//Jarking - 76561199065865022
//string id = "76561198362605034";
namespace userInterfaceTutorial
{
    public partial class SteamStatsForm : Form
    {
        string location = "D:\\Sivaguru\\Programming\\C#\\UI Ux\\userInterfaceTutorial\\userInterfaceTutorial\\Data\\";
        string key = "155E26AAB97BFEAD2F24F1207B55A603";

        public SteamStatsForm()
        {   InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e)
        {start();}

        private void start()
        {
            var tuple = ReadLocalData();
            //set username
            userNameLabel.Text = tuple.Item1;
            //convert Datetime to Date
            string item2 = tuple.Item2;
            try
            {
                item2 = tuple.Item2.Replace(tuple.Item2.Substring(10), "");
            }
            catch (Exception)
            { }
            
            //set date created
            dateCreatedLabel.Text = "Account Created on " + item2;
            //hover over Label Detail reveal
            new ToolTip().SetToolTip(dateCreatedLabel, tuple.Item2);
            //set profile pic
            profilePicBox.ImageLocation = tuple.Item3;
            //set last online date
            LastOnlineLabel.Text = "last Online " + tuple.Item5 + " Ago";
            //set Steam Level
            steamLevelLabel.Text = "Steam Level "+ tuple.Item6;
        }
        private void CheckInput(string id)
        {
            bool checkCustom = id.Any(char.IsLetter);
            if (checkCustom == true)
            {
                GetWebDataCustom(id);
            }
            else
            {
                GetWebData(id);
            }
        }
        private void GetWebDataCustom(string customID)
        {
            try
            {
                var client = new WebClient();
                var importJSONData = client.DownloadString("https://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/?key=" + key + "&vanityurl=" + customID);
                dynamic dobj = JsonConvert.DeserializeObject<dynamic>(importJSONData);
                string id = dobj["response"]["steamid"].ToString();
                GetWebData(id);
            }
            catch (Exception)
            {
                GetWebData("1");
            }
        
        }
        private void GetWebData(string id)
        {
            var client = new WebClient();
            var playerSummary = client.DownloadString("https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0001/?key=" + key + "&steamids=" + id);
            string steamLevel ="{'response':{'steamid':'null'}}";
            try
            {
                steamLevel = client.DownloadString("https://api.steampowered.com/IPlayerService/GetSteamLevel/v1/?key=" + key + "&steamid=" + id);
                WriteLocalData(playerSummary, steamLevel, id);
            }
            catch (Exception)
            {
                WriteLocalData(playerSummary, steamLevel, id);
            }
         
        }
        private void WriteLocalData(string importJSONData,string steamLevel, string id)
        {
            //Writing Local JSON File
            StreamWriter sw1 = new StreamWriter(location + "SteamProfileData.json");
            sw1.WriteLine(importJSONData);
            sw1.Close();
            StreamWriter sw2 = new StreamWriter(location + "SteamLevelData.json");
            sw2.WriteLine(steamLevel);
            sw2.Close();
            StreamWriter sw3 = new StreamWriter(location + "id.txt");
            sw3.WriteLine(id);
            sw3.Close();
        }
        private Tuple<string,string,string,string,string,string> ReadLocalData()
        {
            try
            {
                // STEAM PROFILE DATA FILE READ
                String SteamProfileData;
                StreamReader SteamProfileDataReader = new StreamReader(location+ "SteamProfileData.json");
                SteamProfileData = SteamProfileDataReader.ReadToEnd();
                SteamProfileDataReader.Close();
                dynamic dynamicSteamProfileData = JsonConvert.DeserializeObject<dynamic>(SteamProfileData);

                //retrieve username
                string username = dynamicSteamProfileData["response"]["players"]["player"][0]["personaname"].ToString();

                //retrieve date Created
                string dateCreated = dynamicSteamProfileData["response"]["players"]["player"][0]["timecreated"];

                Double dateCreatedD = Int32.Parse(dateCreated);
                string dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(dateCreatedD).ToString();

                //retrieve porifle pic location
                string profilePicLocation = dynamicSteamProfileData["response"]["players"]["player"][0]["avatarfull"];

                //retrieve last online time
                string lastOnline = dynamicSteamProfileData["response"]["players"]["player"][0]["lastlogoff"];
                Double lastOnlineD = Int32.Parse(lastOnline);
                Double lastOnlineAgo = DateTimeOffset.Now.ToUnixTimeSeconds() - lastOnlineD;
                TimeSpan t = TimeSpan.FromSeconds(lastOnlineAgo);
                string lastOnlineAgoS;
                if (t.Days > 0)
                    lastOnlineAgoS = t.Days.ToString() + " Days " + t.Hours.ToString() + " Hours";
                lastOnlineAgoS = t.Hours.ToString() + " Hours " + t.Minutes.ToString() + " Mins";
                lastOnline = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(lastOnlineD).ToString();

                //STEAM LEVEL DATA READ
                string SteamLevelData;
                StreamReader SteamLevelDataReader = new StreamReader(location+ "SteamLevelData.json");
                SteamLevelData = SteamLevelDataReader.ReadToEnd();
                SteamLevelDataReader.Close();
                dynamic dynamicSteamLevelData = JsonConvert.DeserializeObject<dynamic>(SteamLevelData);
                string steamLevel = dynamicSteamLevelData["response"]["player_level"];

                //submit data
                return new Tuple<string, string, string, string, string,string>(username, dt, profilePicLocation, lastOnline, lastOnlineAgoS,steamLevel);
            }
            catch (Exception)
            {}
            string nodata = "No Data";
            return new Tuple<string, string, string, string, string,string>(nodata,nodata,nodata,nodata,nodata,nodata);
            
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            string newID = newUserValue.Text;
            newID.Trim();
            //check for blank input
            if (newID!="")
            {
                CheckInput(newID);
                newUserValue.Text = "";
                start();
            }
        }

        //Close Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Moveable Form
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //hide and Unhide Settings Panel
        bool settingsPanelShowStatus = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CSGOSelect_Click(object sender, EventArgs e)
        {
            this.GameStatsDisplayPanel.Controls.Clear();
            csgoStatsForm csgoStatsFormObj = new csgoStatsForm() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            csgoStatsFormObj.FormBorderStyle = FormBorderStyle.None;
            this.GameStatsDisplayPanel.Controls.Add(csgoStatsFormObj);
            csgoStatsFormObj.Show();
        }
    }
}
