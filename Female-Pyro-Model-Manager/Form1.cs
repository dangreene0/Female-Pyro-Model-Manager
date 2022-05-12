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
using Microsoft.Win32;
using System.Threading;

namespace Female_Pyro_Model_Manager
{
    public partial class Form1 : Form
    {
        private string folderName;
        private string paintFile = "paints.txt";
        private string cosmeticsFile = "cosmetics.txt";

        public Form1()
        {
            InitializeComponent();

            List<string> paintList = new List<string>();
            List<string> cosmeticList = new List<string>();

            // Reads the data from the given file and stores it in the given list
            ReadList(paintList, paintFile);
            ReadList(cosmeticList, cosmeticsFile);

            // Displays the lists in their respective boxes
            DisplayPaint(paintList);
            DisplayCosmetics(cosmeticList);

            const string valueName = "SteamPath";
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam");
            string registryLocation = reg.GetValue(valueName).ToString();

            string gameLocation = "/steamapps/common/Team Fortress 2";
            string customLocation = gameLocation + "/tf/custom";
            gameTextBox.Text = registryLocation + gameLocation;
            exportTextBox.Text = registryLocation + customLocation;
         
            gameBrowser.SelectedPath = registryLocation;
        }

        private void ReadList(List<string> list, string file)
        {
            try
            {
                StreamReader inputFile = File.OpenText(file);

                while (!inputFile.EndOfStream)
                {
                    list.Add(inputFile.ReadLine());
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayPaint(List<string> paintList)
        {
            foreach (string paint in paintList)
            {
                paintListBox.Items.Add(paint);
            }
        }

        private void DisplayCosmetics(List<string> cosmeticsList)
        {
            foreach (string cosmetic in cosmeticsList)
            {
                cosmeticListBox.Items.Add(cosmetic);
            }
        }

        private void cosmeticListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cosmeticListBox.Enabled = false;
        }

        private void paintListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            paintListBox.Enabled = false;
        }

        private void packBtn_Click(object sender, EventArgs e)
        {
            packProgressBar.Value = 0;
            packingText.Text = "Packing...";

            int i = 0;
            while(i < 10 ){
                packProgressBar.Value += 10;
                i++;
                Thread.Sleep(500);
            }
            packingText.Text = "Done.";
        }

        private void gameLocaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = gameBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = gameBrowser.SelectedPath;
                gameTextBox.Text = folderName;
            }
        }

        private void exportLocaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = exportBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = exportBrowser.SelectedPath;
                exportTextBox.Text = folderName;
            }
        }

        private void creditAlaxe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/secretlyapyro/myworkshopfiles/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/secretlyapyro/myworkshopfiles/");
        }
    }
}
