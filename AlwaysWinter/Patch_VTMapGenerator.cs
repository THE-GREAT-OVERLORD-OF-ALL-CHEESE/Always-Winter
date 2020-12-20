using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using UnityEngine;

[HarmonyPatch(typeof(VTMapGenerator), "Generate")]
class Patch_VTMapGenerator_Generate
{
    [HarmonyPrefix]
    static bool Prefix(VTMapGenerator __instance)
    {
        Debug.Log("Adding snow!");
        __instance.biome = MapGenBiome.Biomes.Arctic;
        return true;
    }
}
