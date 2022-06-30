using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WorldMapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        WorldMapGenerator mapGen = (WorldMapGenerator)target;
        //DrawDefaultInspector();

        // This doubles the public variables shown in the inspector for some reason.
        
        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }
        

        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
}
