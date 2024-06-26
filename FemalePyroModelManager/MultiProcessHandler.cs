﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace FemalePyroModelManager
{
    public class MultiProcessHandler
    {
        public List<string> listOfPossibleBadVPKS = new List<string>();
        private ModelManager form = new ModelManager();

        public Task Waitforprocess(Process p, string file, string vpkfilepath)
        {

            listOfPossibleBadVPKS.Clear();
            return Task.Run(() =>
            {

                Thread disableThread =
                            new Thread(new ThreadStart(this.DisableAllFeatures));
                disableThread.Start();
                while (!p.HasExited)
                {

                }

                if (vpkfilepath != "")
                {
                    if (!File.Exists(vpkfilepath))
                    {
                        listOfPossibleBadVPKS.Add(vpkfilepath);
                    }
                }

                try
                {
                    // Check if file exists with its full path    
                    if (File.Exists(file))
                    {
                        // If file found, delete it    
                        File.Delete(file);
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }

            });

        }
        public void DisableAllFeatures()
        {
            form.ToggleControls(false);
        }
        public void EnableAllFeatures()
        {
            form.ToggleControls(true);
        }

        public Task WaitforAllDone(List<ProcessCount> p)
        {
            return Task.Run(() =>
            {
                int closedprocess = 0;
                while (closedprocess < p.Count)
                {
                    foreach (ProcessCount Item in p)
                    {
                        if (Item.p.HasExited && !Item.Done)
                        {
                            Item.Done = true;
                            closedprocess++;
                        }
                    }
                }
            });
        }
    }
    public class ProcessCount
    {
        public Process p { get; set; }

        public bool Done { get; set; }
    }
}
