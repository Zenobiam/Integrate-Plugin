using System.Drawing;

namespace ds.test.impl.Interfaces
{
    /// <summary>
    /// Интерфейс для плагинов.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Имя плагина
        /// </summary>        
        string PluginName { get; }
        
        /// <summary>
        /// Версия плагина
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Изображение для плагина
        /// </summary>
        Image Image { get; }

        /// <summary>
        /// Описание плагина
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Запустить плагин с заданными входными данными.
        /// </summary>
        int Run(int input1, int input2);
    }
}