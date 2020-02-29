using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Infrastructure
{
    public class SystemDefaults
    {
        public static string ApplicationConfigurationDirectory => @"C:\MyApp";

        public static string ApplicationConfigurationFile => Path.Combine(ApplicationConfigurationDirectory, "settings.settings");




    }
}
