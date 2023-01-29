using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapChanger
{
    public partial class StartupForm : Form
    {
        bool closeapp = true;
        public StartupForm()
        {
            InitializeComponent();
        }
        private Config conf;

        private bool SetupConfig()
        {
            if (File.Exists("Config.json"))
            {
                try
                {
                    var confJson = File.ReadAllText("Config.json");
                    conf = JsonConvert.DeserializeObject<Config>(confJson);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            AppendLog("Loading config...");
            if (SetupConfig())
            {
                AppendLog("Config loaded successfully.");
                if (string.IsNullOrEmpty(conf.PaladinsFolder) || !Paladins.IsPaladinsFolder(conf.PaladinsFolder))
                {
                    AppendLog("Paladins folder set in config is incorrect!");
                    AppendLog("You can set it manually or I can find it myself :)");
                    this.Height = 300;

                }
                else
                {
                    RunApp();
                }
            }
            else
            {
                AppendLog("Failed to load the config.");
                AppendLog("Cannot run without config.");
            }
        }
        private void AppendLog(string log)
        {
            logBox.AppendText(log + Environment.NewLine);
        }
        private void RunApp()
        {
            closeapp = false;
            new MapChanger(conf).Show();
            this.Close();
        }

        private async void ButtonAuto_Click(object sender, EventArgs e)
        {
            AppendLog("Searching all logical drives...");
            var drives = Directory.GetLogicalDrives();
            var found = false;
            foreach (var drive in drives)
            {
                string paldir = null;
                await Task.Run(() =>
                {
                    paldir = Paladins.FindPaladinsFolder(drive);
                });
                if(paldir != null)
                {
                    found = true;
                    conf.PaladinsFolder = paldir;
                    File.WriteAllText("Config.json", JsonConvert.SerializeObject(conf,Formatting.Indented));
                    RunApp();
                    break;
                }
            }
            if(found is false)
            {
                AppendLog("Sorry! I cannot find paladins install directory!");
            }
        }

        private void StartupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeapp)
                Application.Exit();
        }

        private void ButtonManual_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                if (Paladins.IsPaladinsFolder(folderDialog.SelectedPath))
                {
                    conf.PaladinsFolder = folderDialog.SelectedPath;
                    File.WriteAllText("Config.json", JsonConvert.SerializeObject(conf, Formatting.Indented));
                    RunApp();
                }
                else
                {
                    AppendLog("Selected folder is invalid.");
                }
            }
            else
            {
                AppendLog("Folder selection cancelled by user.");
            }
        }
    }
}
