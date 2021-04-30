using System.Reflection;
using System.Linq;
using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using UnityEngine;
using IPA.Utilities;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace FireworksEverywhere.Configuration
{
    internal class PluginConfig
    {
        public static PluginConfig Instance { get; set; }
        public virtual bool LeaveFireworksEnabled { get; set; } = true;
        public virtual float MinSpawnInterval { get; set; } = 0.2f;
        public virtual float MaxSpawnInterval { get; set; } = 1f;
        public virtual float LightIntensityMultiplier { get; set; } = 1f;
        public virtual float LightFlashDuration { get; set; } = 1f;
        public virtual float MinSpeedMultiplier { get; set; } = 0.8f;
        public virtual float MaxSpeedMultiplier { get; set; } = 1.16f;
        public virtual bool EnableRandomColors { get; set; } = false;
        public virtual Color LightsColor { get; set; } = new Color(0f, 0.7529412f, 1f, 1f);
        public virtual Vector3 SpawnSize { get; set; } = new Vector3(30f, 4f, 5f);

        /// <summary>
        /// This is called whenever BSIPA reads the config from disk (including when file changes are detected).
        /// </summary>
        public virtual void OnReload()
        {
            // Do stuff after config is read from disk.
        }

        /// <summary>
        /// Call this to force BSIPA to update the config file. This is also called by BSIPA if it detects the file was modified.
        /// </summary>
        public virtual void Changed()
        {
            // Do stuff when the config is changed.
        }

        /// <summary>
        /// Call this to have BSIPA copy the values from <paramref name="other"/> into this config.
        /// </summary>
        public virtual void CopyFrom(PluginConfig other)
        {
            // This instance's members populated from other
        }
    }
}
