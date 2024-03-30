using ds.test.impl.Interfaces;

namespace ds.test.impl.Base
{
    /// <summary>
    /// Статический класс, предоставляющий доступ к плагинам.
    /// </summary>
    public static class Plugins
    {
        /// <summary>
        /// Словарь, в котором содержаться плагины, где ключ - имя плагина, а значение - экземпляр плагина IPlugin
        /// </summary>
        private static Dictionary<string, IPlugin> _plugins = new Dictionary<string, IPlugin>();

        /// <summary>
        /// Возвращает количество зарегистрированных плагинов
        /// </summary>
        public static int PluginsCount => _plugins.Count;

        /// <summary>
        /// Возвращает имя зарегистрированного плагина
        /// </summary>
        public static string[] GetPluginNames => _plugins.Keys.ToArray();

        /// <summary>
        /// Получение экземпляра плагина по его имени
        /// </summary>
        public static IPlugin GetPlugin(string pluginName)
        {
            if (_plugins.ContainsKey(pluginName))
                return _plugins[pluginName];
            else
                throw new ArgumentException("Plugin not found");
        }
    }
}
