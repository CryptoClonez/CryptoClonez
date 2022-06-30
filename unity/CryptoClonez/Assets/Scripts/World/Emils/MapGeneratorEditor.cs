using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        MapGenerator generator = (MapGenerator)target;

        if (DrawDefaultInspector())
        {
            if (generator.autoUpdate)
            {
                generator.Generate();
            }
        }
        if (GUILayout.Button(("Generate")))
        {
            generator.Generate();
        }
    }
}
