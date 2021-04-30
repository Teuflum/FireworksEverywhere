using FireworksEverywhere.Configuration;
using HarmonyLib;
using IPA.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FireworksEverywhere.HarmonyPatches
{
    [HarmonyPatch(typeof(FireworkItemController), "SetLightsColor")]
    internal class FireworkItemController_SetLightsColor
    {
        internal static bool Prefix(ref Color ____lightsColor)
        {
            if (PluginConfig.Instance.EnableRandomColors)
                ____lightsColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            else
                ____lightsColor = PluginConfig.Instance.LightsColor;
            return true;
        }
    }

    [HarmonyPatch(typeof(FireworkItemController), "FireCoroutine")]
    internal class FireworkItemController_FireCoroutine
    {
        internal static bool Prefix(ref float ____lightFlashDuration, ref float ____minSpeedMultiplier, ref float ____maxSpeedMultiplier)
        {
            ____lightFlashDuration = PluginConfig.Instance.LightFlashDuration;
            ____minSpeedMultiplier = PluginConfig.Instance.MinSpeedMultiplier;
            ____maxSpeedMultiplier = PluginConfig.Instance.MaxSpeedMultiplier;
            return true;
        }
    }
}
