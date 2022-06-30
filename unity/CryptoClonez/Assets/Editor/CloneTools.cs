using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class CloneTools : EditorWindow
{
    public int cloneInput = 0;
    bool autoPlay = false;
    float time = 0;

    [MenuItem("Window/Clone Tools")]
	public static void ShowWindow()
	{
		EditorWindow window = EditorWindow.GetWindow<CloneTools>("Clone Tools");
	}

    private void OnGUI()
    {
        if (Application.isPlaying)
        {
            string thisString = "Clone: " + (GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().currentClone.ToString());

            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Previous"))
            {
                GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().PreviousClone();
            }
            if (GUILayout.Button("Next"))
            {
                GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().NextClone();
            }
            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("Random"))
            {
                GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().RandomClone();
            }
            EditorGUI.LabelField(new Rect(10, 10, position.width, 10), thisString);

            if (GUILayout.Button("All Unique?"))
            {
                GameObject.Find("Uniqueness").GetComponent<UniquenessTest>().TestForUniqueness();
            }
            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Select Clone"))
            {
                GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().currentClone = cloneInput;
                GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().SelectedClone();
            }
            cloneInput = EditorGUILayout.IntField(cloneInput);
            EditorGUILayout.EndHorizontal();
            autoPlay = EditorGUILayout.Toggle("Auto Play",autoPlay);
                
        }
    }

    private void Update()
    {
        if (autoPlay)
        {          
            time = time + 0.01f;
            if(time >= 15f)
            {
                time = 0f;
                GameObject.Find("CloneNavigation").GetComponent<CloneNavigation>().RandomClone();
            }
        }
    }
}
