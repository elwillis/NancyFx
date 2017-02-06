using System.Configuration;

namespace Tezra.Plugin
{
    public class PluginConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("path", IsKey = true, IsRequired = true)]
        public string Path
        {
            get { return (string)this["path"]; }
        }

        [ConfigurationProperty("type", IsKey = false, IsRequired = true)]
        public string Type
        {
            get { return (string)this["type"]; }
        }
    }
}
