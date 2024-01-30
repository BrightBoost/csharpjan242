using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    // voorbeeld singleton
    internal class AppConfiguratie
    {
        private static AppConfiguratie config;

        private AppConfiguratie() { }

        public static AppConfiguratie GetInstance()
        {
            if(config != null)
            {
                return config;
            } 
            else
            {
                config = new AppConfiguratie();
                return config;
            }
        }
    }
}
