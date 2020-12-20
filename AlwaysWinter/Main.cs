using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Harmony;
using System.Reflection;

public class AlwaysWinter : VTOLMOD
{
    public Material arcticMaterial;

    public override void ModLoaded()
    {
        HarmonyInstance harmony = HarmonyInstance.Create("cheese.winter");
        harmony.PatchAll(Assembly.GetExecutingAssembly());

        Debug.Log("its winter now");

        base.ModLoaded();
    }

    //my unsecsessful attempt to make akutan snowy also
    /*
    public void SceneLoaded(VTOLScenes scene)
    {
        switch (scene)
        {
            case VTOLScenes.Akutan:
                Debug.Log("unstealing the shit!");
                GameObject akutan = GameObject.Find("akutan2");
                foreach (MeshRenderer renderer in akutan.GetComponentsInChildren<MeshRenderer>()) {
                    renderer.material.SetColor("_Color", arcticMaterial.GetColor("_Color"));
                    renderer.material.SetTexture("_TileR", arcticMaterial.GetTexture("_TileR"));
                    renderer.material.SetTexture("_TileR_NRM", arcticMaterial.GetTexture("_TileR_NRM"));
                    renderer.material.SetFloat("_RScale", arcticMaterial.GetFloat("_RScale"));
                    renderer.material.SetColor("_RTint", arcticMaterial.GetColor("_RTint"));
                    renderer.material.SetTexture("_TileG", arcticMaterial.GetTexture("_TileG"));
                    renderer.material.SetTexture("_TileG_NRM", arcticMaterial.GetTexture("_TileG_NRM"));
                    renderer.material.SetFloat("_GScale", arcticMaterial.GetFloat("_GScale"));
                    renderer.material.SetColor("_GTint", arcticMaterial.GetColor("_GTint"));
                    renderer.material.SetTexture("_TileB", arcticMaterial.GetTexture("_TileB"));
                    renderer.material.SetTexture("_TileB_NRM", arcticMaterial.GetTexture("_TileB_NRM"));
                    renderer.material.SetFloat("_BScale", arcticMaterial.GetFloat("_BScale"));
                    renderer.material.SetColor("_BTint", arcticMaterial.GetColor("_BTint"));
                    renderer.material.SetTexture("_TileA", arcticMaterial.GetTexture("_TileA"));
                    renderer.material.SetTexture("_TileA_NRM", arcticMaterial.GetTexture("_TileA_NRM"));
                    renderer.material.SetFloat("_AScale", arcticMaterial.GetFloat("_AScale"));
                    renderer.material.SetColor("_ATint", arcticMaterial.GetColor("_ATint"));
                    renderer.material.SetTexture("_BeachTex", arcticMaterial.GetTexture("_BeachTex"));
                    renderer.material.SetFloat("_BeachScale", arcticMaterial.GetFloat("_BeachScale"));
                    renderer.material.SetFloat("_NrmAmt", arcticMaterial.GetFloat("_NrmAmt"));
                }
                break;
            case VTOLScenes.CustomMapBase:
                Debug.Log("stealing the shit!");
                VTMapGenerator mapGenerator = GetComponent<VTMapGenerator>();
                arcticMaterial = mapGenerator.biomeProfiles[(int)MapGenBiome.Biomes.Arctic].terrainMaterial;
                break;
        }
    }*/
}