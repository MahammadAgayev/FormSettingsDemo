using Homework.Enums;
using Homework.Infrastructure;
using Homework.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Models
{
    public class Settings
    {
        private Settings() { }

        #region singleton pattern
        public static Settings settings;
        public static Settings Get()
        {
            try
            {
                if (settings == null)
                {
                    string raw = File.ReadAllText(SystemDefaults.ApplicationConfigurationFile);
                    settings = JsonConvert.DeserializeObject<Settings>(raw);
                }
               
            }
            catch
            {
                settings = new Settings();
            }
            return settings;
        }
        #endregion

        public string Language { get; set; }
        public VendorTypes Vendor { get; set; }

        public  void Save()
        {
            string raw = JsonConvert.SerializeObject(this);
            File.WriteAllText(SystemDefaults.ApplicationConfigurationFile,raw);
        }
    }
}
