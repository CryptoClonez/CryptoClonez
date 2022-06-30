using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using World;

public class MapGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public int xSize = 20;
    public int zSize = 20;
    private float[,] noiseMap;

    [SerializeField] [Range(0.001f, 50)] private float noiceScale = 1;
    [SerializeField] [Range(1, 10)] private int octaves = 1;
    [SerializeField] [Range(0.001f, 2)] private float persistance = 1;
    [SerializeField] [Range(0.001f, 2)] private float lacunarity = 1;

    [SerializeField] private int seed;
    [SerializeField] private Vector2 offset;

    [SerializeField]
    private Material material;
    
    [SerializeField] 
    private List<BiomType> bioms;

    public bool drawNoiceMap = true;
    public bool autoUpdate = false;


    
    public void GenerateTexture()
    {
        CreateNoiseMap();
        DrawMapTexture();
    }

    private void CreateNoiseMap()
    {
        noiseMap = new float [xSize+1,zSize+1];

        System.Random prng = new System.Random(seed);
        var octaveOffset = new Vector2[octaves];
        for (int i = 0; i < octaves; i++)
        {
            float offsetX = prng.Next(-100000, 100000) + offset.x;
            float offsetY = prng.Next(-100000, 100000)+ offset.y;
            octaveOffset[i] = new Vector2(offsetX, offsetY);
        }
        
        float minNoise = float.MaxValue;
        float maxNoise = float.MinValue;

        float halfwidth = xSize / 2f;
        float halfheight = zSize / 2f;
        
        
        for (int z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                float amplitude = 1f;
                float frequenzy = 1f;
                float noiseHeight = 0f;
                for (int o = 0; o < octaves;o++)
                {
                    var perlinValue = CalculateHeight(x-halfwidth, z-halfheight, frequenzy, octaveOffset[o]) ;

                    noiseHeight += perlinValue * amplitude;
                    amplitude *= persistance;
                    frequenzy *= lacunarity;
                }

                if (noiseHeight > maxNoise) {
                    maxNoise = noiseHeight;
                }else if (noiseHeight < minNoise) {
                    minNoise = noiseHeight;
                }
                
                noiseMap[x, z] = noiseHeight;
            }
        }

        for (int z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                noiseMap[x, z] = Mathf.InverseLerp(minNoise, maxNoise, noiseMap[x, z]);
            }
        }
    }
    private float CalculateHeight(float x, float z, float frequenzy, Vector2 octaveOffset)
    {
        float elevation =    Mathf.PerlinNoise( x/noiceScale * frequenzy +octaveOffset.x,  z/noiceScale *frequenzy+octaveOffset.y) * 2 - 1;
        return elevation;

    }
    private void DrawMapTexture()
    {
        Color[] colorMap = new Color[(xSize+1)*(zSize+1)];
        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                
                if (drawNoiceMap)
                {
                    colorMap[z * xSize + x] = Color.Lerp(Color.black, Color.white, noiseMap[x, z] );  
                }
                else
                {
                    colorMap[z * xSize + x] = GetColor(x, z);
                }

            }
        }

        Texture2D texture = new Texture2D(xSize, zSize);
        material.mainTexture = texture;
        texture.SetPixels(colorMap);
        texture.Apply();
    }
    
    private Color GetColor(int x, int z)
    {
        var height = noiseMap[x, z] ;
        foreach (var biom in bioms)
        {
            if (height < biom.height)
            {
                return biom.Color;
            }
        }
        
        return Color.magenta;
    }

    public void Generate()
    {
        GenerateTexture();
    }

    public float GetHeightAt(int x, int z)
    {
        return noiseMap[x, z];
    }
    
    public int GetSizeX()
    {
        return xSize;
    }
    public int GetSizeZ()
    {
        return zSize;
    }

    public Material GetMaterial()
    {
        return material;
    }

    public bool hasNoiceMap()
    {
        return noiseMap != null;
    }
}
