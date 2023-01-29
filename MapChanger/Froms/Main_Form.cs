using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MapChanger
{
    public partial class MapChanger : Form
    {
        public Config conf;
        private Image buttonIdle;
        private Image buttonHover;
        public MapChanger(Config config)
        {
            InitializeComponent();
            conf = config;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            conf = JsonConvert.DeserializeObject<Config>(
               File.ReadAllText("Config.json"));


            mapSelector.DataSource = conf.Maps;
            mapSelector.ValueMember = "Name";
            mapSelector.SelectedIndex = -1;

            buttonIdle = Image.FromFile(conf.GetImage(conf.ButtonIdle));
            buttonHover = Image.FromFile(conf.GetImage(conf.ButtonHover));
            foreach (var control in Controls)
            {
                if (control is Button b)
                {
                    b.Image = buttonIdle;
                }
            }


            //MessageBox.Show("Select the 'Paladins' folder (steam/steamapps/common)","folder selection");
            //do {
            //    if (Fldr.ShowDialog() == DialogResult.OK)
            //    {
            //        mainpath = Fldr.SelectedPath.ToString() + "\\ChaosGame\\CookedPCConsole\\";
            //        if (!File.Exists(mainpath + training))
            //        {
            //            if (MessageBox.Show("Wrong Folder,or run the app as administrator.\ndo you want to try again?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
            //                Application.Exit();
            //        }
            //    }
            //    else
            //        Application.Exit();
            //   } while (!File.Exists(mainpath+training));
        }

        private void MapSelector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MapSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapSelector.SelectedItem is Map map)
            {
                picture.ImageLocation = conf.GetImage(map.Image);
            }
            else
            {
                picture.ImageLocation = conf.GetImage(conf.DefaultImage);
            }
        }

        private void AllButtons_MouseEnter(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.Image = buttonHover;
            if (b.Equals(restoreButton))
            {
                picture.ImageLocation = conf.GetImage(conf.TrainingImage);
            }
        }

        private void AllButtons_MouseLeave(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.Image = buttonIdle;
            if (b.Equals(restoreButton))
            {
                if(mapSelector.SelectedItem is Map selectedMap)
                {
                    picture.ImageLocation = conf.GetImage(selectedMap.Image);
                }
                else
                {
                    picture.ImageLocation = conf.GetImage(conf.DefaultImage);
                }
            }
        }

        private void MapChanger_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if(mapSelector.SelectedItem is Map map)
            {
                Paladins.ChangeMap(conf.PaladinsFolder, conf.GetMap(map.FileName));
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Paladins.Restore(conf.PaladinsFolder, conf.GetMap(conf.TrainingMap));
        }
    }
}
