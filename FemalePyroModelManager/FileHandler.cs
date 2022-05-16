using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Reflection;

namespace FemalePyroModelManager
{
    class FileHandler
    {
        public string vpkExeDir;
        string tempDir = Path.GetTempPath() + "/Alaxe-Models";
      

        public void packFiles(string vpkName, string gameDir, string exportDir, params string[] cosmetics)
        {
            try
            {
                if (Directory.Exists(tempDir))
                {
                    MessageBox.Show("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(tempDir);
                MessageBox.Show($"The directory was created successfully at {Directory.GetCreationTime(tempDir).ToString()}");

            }
            catch (IOException e)
            {
                MessageBox.Show("Failed to move zip file.\n\n" + e);
            }

            try 
            {
                File.WriteAllBytes(tempDir + "/models.zip", Properties.Resources.Arm_Models);
            }
            catch (IOException e)
            {
                MessageBox.Show("Unable to extract files\n\n" + e);
            }

            try
            {
                ZipFile.ExtractToDirectory(tempDir + "/models.zip", tempDir);

            }
            catch (IOException e)
            {
                MessageBox.Show("Failed to extract zip file.\n\n" + e);
            }
      

            vpkExeDir = gameDir + "/vpk.exe";

            try
            {
                System.Diagnostics.Process.Start(vpkExeDir, vpkName);

            }
            catch (Exception e){
                MessageBox.Show("Unable to fine vpk.exe.\n Are you pointing to the wrong \"bin\" folder?\n" + e);
;           }

            if (cosmetics.Count() < 0)
            {
                MessageBox.Show(cosmetics[0]);
            }

            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, true);
                MessageBox.Show("The directory was deleted successfully.");
            }
        }
    }
}
