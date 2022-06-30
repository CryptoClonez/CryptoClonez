using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapGenerator : MonoBehaviour
{
    public int mapHeight;
    public int mapWidth;
    public float noiseScale;
    public bool autoUpdate;
    public void GenerateMap()
    {
        float[,] noiseMap = WorldMapNoise.GenerateNoiseMap(mapWidth,mapHeight,noiseScale);

        MapDisplay display = FindObjectOfType<MapDisplay>();
        display.DrawNoiseMap(noiseMap);
    }
}
