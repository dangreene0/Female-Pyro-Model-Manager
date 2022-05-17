using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Diagnostics;

namespace FemalePyroModelManager
{
    class FileHandler
    {
        public string vpkExeDir;
        private string vpkFileName;
        private string tempDir = Path.GetTempPath() + "Alaxe-Models/Arm_Models";
        private PaintCheck paintCheck = new PaintCheck();
        private string paintVal;

        public void packFiles(string vpkName, string gameDir, string exportDir, List<string> cosmetics, params string[] paintName)
        {
            vpkFileName = vpkName;
            upProgress(5);

            //MakeDir();
            /*ExportZip();
            ExtractZip();*/
/*
            SelectCosmetics(cosmetics, exportDir);
*/
            if (paintName.Count() > 0) // TODO have select cosmetics call place paint
            {
                vpkName += " " + paintName[0];
                paintVal = paintCheck.getPaint(paintName[0]);
                // ApplyPaint(paintVal);
                MessageBox.Show(paintVal);
            }

            vpkExeDir = gameDir;
            TouchVPK(cosmetics,exportDir);
 
            // DeleteTempDir();
        }
        private void MakeDir()
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
                MessageBox.Show("Unable to create directory, check your user permissions.\n\n" + e);
            }
            upProgress(5);
        }
        private void ExportZip()
        {
            try
            {
                File.WriteAllBytes(tempDir + "/models.zip", Properties.Resources.Arm_Models);
            }
            catch (IOException e)
            {
                MessageBox.Show("Unable to export zip file to Temp folder. Check user permissions.\n\n" + e);
            }
            upProgress(5);
        }
        private void ExtractZip()
        {
            try
            {
                ZipFile.ExtractToDirectory(tempDir + "/models.zip", tempDir);

            }
            catch (IOException e)
            {
                MessageBox.Show("Failed to extract zip file.\n\n" + e);
            }
            upProgress(5);
        }
        private void SelectCosmetics(List<string> cosmetics, string exportDir)
        {
            /*string path = tempDir + "/" + cosmetics[1];
            string path2 = exportDir;
            try
            {
                if (!File.Exists(path))
                {
                    // This statement ensures that the file is created,
                    // but the handle is not kept.
                    using (FileStream fs = File.Create(path)) { }
                }

                // Ensure that the target does not exist.
                if (File.Exists(path2))
                    File.Delete(path2);

                // Move the file.
                File.Move(path, path2);
                Console.WriteLine("{0} was moved to {1}.", path, path2);

                // See if the original exists now.
                if (File.Exists(path))
                {
                    Console.WriteLine("The original file still exists, which is unexpected.");
                }
                else
                {
                    Console.WriteLine("The original file no longer exists, which is expected.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            if (cosmetics.Count() > 2)
            {
                // grabs both
            }*/
        }
        private void ApplyPaint(string paintVal, string cosmDir)
        {
            string text = File.ReadAllText(cosmDir);
            text = text.Replace("{PAINT}", paintVal);
            File.WriteAllText(cosmDir, text);
        }

        private async void TouchVPK(List<string> cosmetics, string exportDir)
        {
            List<ProcessCount> listofprocess = new List<ProcessCount>();

            var mpHandler = new MultiProcessHandler();
            MessageBox.Show(vpkExeDir);
            if (File.Exists(vpkExeDir + "\\bin\\vpk.exe"))
            {
                MessageBox.Show(vpkExeDir + "\\bin\\vpk.exe");
                try
                {
                    string path = tempDir + "/" + cosmetics[1];
                    string path2 = exportDir;
                    MessageBox.Show(vpkExeDir + path);

                    Process vpak3 = new Process();


                    vpak3.StartInfo.FileName = "CMD.exe";

                    string quote = "\"";
                    vpak3.StartInfo.Arguments = @"/c " + "cd /d " + quote + path2 + quote + "\\bin && start " + "/wait " + "vpk.exe " + quote + path + quote;


                    vpak3.StartInfo.UseShellExecute = false;

                    vpak3.StartInfo.CreateNoWindow = true;

                    vpak3.StartInfo.LoadUserProfile = true;

                    vpak3.StartInfo.RedirectStandardError = true;

                    vpak3.StartInfo.RedirectStandardInput = true;

                    vpak3.StartInfo.RedirectStandardOutput = true;

                    listofprocess.Add(new ProcessCount
                    {
                        p = vpak3,
                        Done = false
                    });

                    vpak3.Start();

                    await mpHandler.Waitforprocess(vpak3, "", "");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Unable to find vpk.exe.\n Are you pointing to the wrong \"bin\" folder?\n\n" + e);
                }
            }
            //await mpHandler.WaitforAllDone(listofprocess);

            upProgress(5);
        }
        private void DeleteTempDir()
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, true);
                MessageBox.Show("The directory was deleted successfully.");
            }
            upProgress(5);
        }
        private void upProgress(int i)
        {
            var form = Form.ActiveForm as ModelManager;
            try
            {
                if (form != null)
                {
                    form.packProgressBar.Value += i;
                }
            } catch(Exception e)
            {
                MessageBox.Show("Progress Cannot go above 100.\n\n" + e);
            }
            
        }
    }
}
