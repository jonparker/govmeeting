﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public static class Common
    {
        public static string getDataPath()
        {
            // "Datafiles" folder is at same level with "WebApp"
            // Todo: We need a better way to locate Datafiles than traversing relative to current project folder.
            string appfolder = Directory.GetCurrentDirectory();
            return System.IO.Path.Combine(appfolder, "..\\..\\Datafiles");

            // We used to have the data in wwwroot\assets/data
            //string siteDataPath = "assets/data";
            //var webRoot = _env.WebRootPath;
            //return System.IO.Path.Combine(webRoot, siteDataPath);
        }
        public static string Readfile(string path)
        {
            try
            {
                string text = System.IO.File.ReadAllText(path);
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
