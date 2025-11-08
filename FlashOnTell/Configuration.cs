using Dalamud.Configuration;
using Dalamud.Plugin;
using Newtonsoft.Json;

namespace FlashOnTell
{
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; }

        // 配置保存时不序列化插件接口
        [JsonIgnore] private IDalamudPluginInterface pluginInterface = null!;

        public void Initialize(IDalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;

        }

        public void Save()
        {
            pluginInterface.SavePluginConfig(this);
        }
    }
}
