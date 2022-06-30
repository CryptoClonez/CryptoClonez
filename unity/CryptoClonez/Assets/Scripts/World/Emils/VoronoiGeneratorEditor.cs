using UnityEditor;
using UnityEngine;

namespace World
{
   
    [CustomEditor(typeof(VoronoiGenerator))]
    public class VoronoiGeneratorEditor : Editor
    {
    
        public override void OnInspectorGUI()
        {
            VoronoiGenerator generator = (VoronoiGenerator)target;

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
}