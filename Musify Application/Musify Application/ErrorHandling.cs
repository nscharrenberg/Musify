using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musify_Application
{
    class ErrorHandling
    {
        public void WriteToFile(string msg)
        {
            string errorPath = ConfigurationManager.AppSettings["ErrorLog"];
            StreamWriter sw;
            string dt = DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm:ss");

            if (!File.Exists(errorPath))
            {
                try
                {
                    using (sw = File.CreateText(errorPath))
                    {
                        sw.WriteLine(dt + " --- " + msg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to  Create File : " + ex.Message);
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
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show("Unable to load File : " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add lines to file : " + ex.Message);
                }
            }
        }
    }
}
