using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

[ExecuteInEditMode]
public class CleanUp : EditorWindow
{

    [MenuItem("Window/CleanUp")]
    public static void ShowWindow()
    {
        EditorWindow window = EditorWindow.GetWindow<CleanUp>("Clean Up");
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Clean Up Textures"))
        {
            CleanUpTextures();
        }

        if (GUILayout.Button("Clean Up Folders"))
        {
            CleanUpFolders();
        }
    }

    private void CleanUpTextures()
    {
        List<string> names = new List<string>();
        names.Add("*0001*");
        names.Add("*0002*");
        names.Add("*0003*");

        for (int i = 0; i < names.Count; i++)
        {
            foreach (string file in Directory.GetFiles("Assets/Textures", names[i], SearchOption.AllDirectories))
            {
                Debug.Log("deleting - " + file);
                File.Delete(file);
                Directory.Delete(file);
            }
        }
        names.Add("*Generated*");

    }

    private void CleanUpFolders()
    {

        string archiveDirectory = @"C:\Users\Xric\CryptoClonez\";

        List<string> names = new List<string>();
        names.Add("*Generated*");

        for (int i = 0; i < names.Count; i++)
        {

            // delete folder meta data
            foreach (string file in Directory.GetFiles("Assets/Textures", names[i], SearchOption.AllDirectories))
            {

                File.Delete(file);
            }



            // Delet the directory
            foreach (string dir in Directory.GetDirectories("Assets/Textures", names[i], SearchOption.AllDirectories))
            {
                string fullDirectory = Path.Combine(archiveDirectory, dir);

                foreach (string subDir in Directory.GetFiles(fullDirectory))
                {
                    //Deletes the .meta for the sub folders "Dark" and "Light"
                    File.Delete(subDir);
                }

                foreach (string subDir in Directory.GetDirectories(fullDirectory))
                {
                    string fullSubDirectory = Path.Combine(archiveDirectory, subDir);

                    foreach (string subDirFile in Directory.GetFiles(subDir))
                    {
                        //Deletes the files inside the sub folders
                        File.Delete(subDirFile);
                    }
                    //Deletes the "Dark" & "Light" sub folders

                    Directory.Delete(subDir);
                }

                //Deletes the "Generated" folders
                Directory.Delete(fullDirectory);
            }
        }
    }
}
