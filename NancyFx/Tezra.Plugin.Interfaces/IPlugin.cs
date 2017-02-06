namespace Tezra.Plugin.Interfaces
{
    /// <summary>
    /// Describes the basic functionality exposed by a plugin.
    /// </summary>
    public interface IPlugin : System.IDisposable
    {
        /// <summary>
        /// Gets the name of the plugin.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the description of the plugin.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the plugin version.
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Sets Configuration parameters and initializes to Plug functionalities...
        /// </summary>
        void Initialize();
    }
}
