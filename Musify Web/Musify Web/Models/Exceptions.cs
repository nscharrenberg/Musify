using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Exceptions
    {
        public void WriteToFile(string msg)
        {
            //string errorPath = ConfigurationManager.AppSettings["ErrorLog"];
            string errorPath = @"D:\ErrorLog.log";
            StreamWriter sw;
            string dt = DateTime.Now.ToString("yyyy'/'MM'/'dd HH:mm:ss");
            if (!File.Exists(errorPath))
            {
                try
                {
                    using (sw = File.CreateText(errorPath))
                    {
                        sw.WriteLine(dt + " --- " + msg);
                    }
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    using (sw = File.AppendText(errorPath))
                    {
                        sw.WriteLine(dt + " --- " + msg);
                    }
                } catch { }
            }
        }
    }
}