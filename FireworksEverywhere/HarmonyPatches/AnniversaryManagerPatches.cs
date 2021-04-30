using FireworksEverywhere.Configuration;
using HarmonyLib;
using IPA.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FireworksEverywhere.HarmonyPatches
{
    [HarmonyPatch(typeof(AnniversaryManager), "StartFireworks")]
    internal class AnniversaryManager_StartFireworks
    {
        internal static bool Prefix(ref FireworksController ____fireworksController)
        {
            ____fireworksController.SetField("_minSpawnInterval", PluginConfig.Instance.MinSpawnInterval);
            ____fireworksController.SetField("_maxSpawnInterval", PluginConfig.Instance.MaxSpawnInterval);
            ____fireworksController.SetField("_spawnSize", PluginConfig.Instance.SpawnSize);
            ____fireworksController.SetField("_lightsIntensity", PluginConfig.Instance.LightIntensityMultiplier);
            return true;
        }
    }

    [HarmonyPatch(typeof(AnniversaryManager), "StopFireworks")]
    internal class AnniversaryManager_StopFireworks
    {
        internal static bool Prefix()
        {
            return !PluginConfig.Instance.LeaveFireworksEnabled;
        }
    }
}
