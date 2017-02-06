using System.Configuration;

namespace Tezra.Plugin
{
    [ConfigurationCollection(typeof(PluginConfigurationElement), AddItemName = "plugin")]
    public class PluginConfigurationElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PluginConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PluginConfigurationElement)element).Path;
        }
    }
}
