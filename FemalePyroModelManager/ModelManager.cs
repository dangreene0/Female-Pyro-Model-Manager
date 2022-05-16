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

namespace FemalePyroModelManager
{
    public partial class ModelManager : Form
    {
        private string folderName;
        private string vpkDefaultName = "Female Pyro Viewmodel - ";
        private string vpkName;
        private string cosmeticsFullStream = Properties.Resources.cosmetics;
        private string paintFullStream = Properties.Resources.paints;
        private int selectedCount = 0;
        private FileHandler fileHandler = new FileHandler();

        public ModelManager()
        {
            InitializeComponent();
            
            // Gets the default steam location from the registry
            const string valueName = "SteamPath";
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam");
            string registryLocation = reg.GetValue(valueName).ToString();

            // Sets default location of the tf2 vpk based on steam's location in the registry
            string gameLocation = "/steamapps/common/Team Fortress 2/bin";
            gameTextBox.Text = registryLocation + gameLocation;
            folderName = gameTextBox.Text;

            // Sets default export locations based on steam's location in the registry
            string customLocation = gameLocation + "/tf/custom";
            exportTextBox.Text = registryLocation + customLocation;

            // Creates an array from the embedded text files
            string[] cosmeticsArr = cosmeticsFullStream.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            string[] paintArr = paintFullStream.Split(new string[] { "\r\n" }, StringSplitOptions.None);


            DisplayPaint(paintArr);
            DisplayCosmetics(cosmeticsArr);

        }

        // Displays the cosmetics and paint arrays
        private void DisplayCosmetics(string[] arr)
        {
            foreach (string item in arr)
            {
                cosmeticListBox.Items.Add(item);
            }
        }
        private void DisplayPaint(string[] arr)
        {
            foreach (string item in arr)
            {
                paintListBox.Items.Add(item);
            }
        }

        // Changes all the checkbox values in cosmetics
        private void ChangeAllCheckCosmetics(bool value)
        {
            for (int i = 0; i < cosmeticListBox.Items.Count; i++)
            {
                cosmeticListBox.SetItemChecked(i, value);
            }
        }
        
        // Gets all of the currently listed cosmetics
        private List<string> GetAllCheckCosmetics()
        {
            string cosmeticsStr = "";
            int cosmCount = 0;
            List<string> cosmeticsList = new List<string>();

            for (int i = 0; i < cosmeticListBox.Items.Count; i++)
            {
                // Checks if the checkbox is checked
                if (cosmeticListBox.GetItemChecked(i))
                {
                    // Adds to the count
                    cosmCount++;
                    if (cosmCount == 2) // if theres 2 it adds an 'and' in between
                    {
                        string cosmTwo = cosmeticListBox.Items[i].ToString();
                        cosmeticsList.Add(cosmTwo);

                        cosmeticsStr += " and ";
                    }
                    if (cosmCount == 1)
                    {
                        string cosmOne = cosmeticListBox.Items[i].ToString();
                        cosmeticsList.Add(cosmOne);
                    }
                    cosmeticsStr += cosmeticListBox.Items[i].ToString();
                }
            }
            cosmeticsList.Insert(0, cosmeticsStr);// Puts the file name in the first index
            return cosmeticsList;
        }

        // COSMETICS SELECTED
        private void cosmeticListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Defines the index that was selected to store for later
            int selectInd = cosmeticListBox.SelectedIndex;
            
            // Checks if rail spikes were chosen, if they are then it will not count as a cosmetic.
            foreach (string s in cosmeticListBox.CheckedItems)
            {
                if (s != "Rail Spikes")
                {
                    selectedCount++;
                }
            }
            
            // This has to be seperated or else it will die from over-referencing
            if (selectedCount > 1)
            {
                ChangeAllCheckCosmetics(false);
                
                // Sets the selected back to the one that was just chosen after clearings all of them.
                cosmeticListBox.SetItemChecked(selectInd, true);
                selectedCount = 0; // resets the count, essentially lets rail spikes be selectable.
            }
        }

        // Changes all of the checkbox values in paints
        private void ChangeAllCheckPaints(bool value)
        {
            for (int i = 0; i < paintListBox.Items.Count; i++)
            {
                paintListBox.SetItemChecked(i, value);
            }
        }
       
        // PAINTS SELECTED
        private void paintListBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int selectInd = paintListBox.SelectedIndex; // grabs the current selected checkbox
            // if there is something selected, it removes all the rest and sets it back.
            if (paintListBox.SelectedIndex != -1) // TODO do paintListBox.GetSelected(paintListBox.SelectedIndex) somewhere
            {
                ChangeAllCheckPaints(false);
                paintListBox.SetItemChecked(selectInd, true);
            }
        }
        
        private void packBtn_Click(object sender, EventArgs e)
        {

            packProgressBar.Value = 0;
            if (cosmeticListBox.SelectedIndex != -1 && cosmeticListBox.GetSelected(cosmeticListBox.SelectedIndex))
            {
                packingText.Text = "Packing...";

                List<string> cosmetics = GetAllCheckCosmetics();
                vpkName = vpkDefaultName + cosmetics[0]; // adds the cosmetic string

                string gameDir = gameTextBox.Text;
                string exportDir = exportTextBox.Text;
                fileHandler.packFiles(vpkName, gameDir, exportDir);
            }
            else
            {
                MessageBox.Show("Please Select a Cosmetic.");
            }
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
            System.Diagnostics.Process.Start("https://github.com/dangreene0/Female-Pyro-Model-Manager/releases");
        }
    }
}
