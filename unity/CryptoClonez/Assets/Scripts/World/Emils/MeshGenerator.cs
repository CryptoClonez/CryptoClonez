using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using World;

[CustomEditor(typeof(MeshGenerator))]
public class MeshGeneratorEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        MeshGenerator generator = (MeshGenerator)target;

        if (DrawDefaultInspector())
        {
            if (generator.autoUpdate)
            {
                generator.GenerateMesh();
            }
        }
        if (GUILayout.Button(("Generate")))
        {
            generator.GenerateMesh();
        }
    }
}

public class MeshGenerator : MonoBehaviour
{
    
    //public int xSize = 20;
    //public int zSize = 20;

    [SerializeField] 
    private MeshRenderer render;
    [SerializeField] 
    private MeshFilter meshFilter;
    

    [SerializeField] private MapGenerator mapGenerator;
    
    private Mesh mesh;
    private Vector3[] vertices;
    private int[] triangles;
    private Vector2[] uv;
    public bool autoUpdate;
    public float heightModifier = 10;
    
    public void GenerateMesh()
    {
        if (!mapGenerator.hasNoiceMap())
        {
            mapGenerator.GenerateTexture();
        }
        
        mesh = new Mesh();
        meshFilter.mesh = mesh;

        CreateShape();
        UpdateMesh();
        render.material = mapGenerator.GetMaterial();
    }
    
    void OnValidate()
    {
        GenerateMesh();
        
    }

    private void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        mesh.RecalculateNormals();
    }
    

    private void CreateShape()
    {
        var xSize = mapGenerator.GetSizeX();
        var zSize = mapGenerator.GetSizeZ();
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];
        int i = 0;
        for (int z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                vertices[i] = new Vector3(x, mapGenerator.GetHeightAt(x,z)*heightModifier, z);
                i++;
            }
        }
        int vert= 0;
        int tris= 0;
        triangles = new int[xSize * zSize *6];
        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {

                triangles[tris+0] = vert+0;
                triangles[tris+1] = vert+xSize+1;
                triangles[tris+2] = vert+1;
        
                triangles[tris+3] = vert+1;
                triangles[tris+4] = vert+xSize+1;
                triangles[tris+5] = vert+xSize+2;

                vert++;
                tris += 6;
            }

            vert++;
        }


        uv = new Vector2[vertices.Length];
        i = 0;
        for (int z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                uv[i] = new Vector2((float)x / xSize, (float)z / zSize);
                i++;
            }
        }
        
    }
    
}
