using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tezra.Plugin.Interfaces;

namespace Tezra.Plugin
{
    public static class PluginReader
    {
        private static Type _pluginType;

        public static void LoadPlugin()
        {
            PluginConfigurationSection config = (PluginConfigurationSection)ConfigurationManager.GetSection("plugins");

            PluginConfigurationElementCollection collection = config.Plugins;

            foreach (PluginConfigurationElement pluginConfig in collection)
            {
                string path = pluginConfig.Path;
                string startingType = pluginConfig.Type;

                // Load the assembly and retrieve its type.
                Assembly pluginAssembly = Assembly.LoadFile(path);
                _pluginType = pluginAssembly.GetType(startingType);

                //To configure any parameters for the plugin...
                //Dictionary<string, object> configurationParameters = new Dictionary<string, object>();
                //entryType.Configure(configurationParameters);

                
            }
        }
    }
}
