using System.Configuration;

namespace Tezra.Plugin
{
    public class PluginConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public PluginConfigurationElementCollection Plugins
        {
            get { return (PluginConfigurationElementCollection)this[""]; }
        }
    }
}
