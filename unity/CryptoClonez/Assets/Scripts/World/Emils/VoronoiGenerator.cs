using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;


public class VoronoiGenerator : MonoBehaviour
{
    public Material material;
    public int nrOfPoints = 50;
    public bool autoUpdate;
    public bool drawpointsOnly;
    public bool drawColorRegions;
    public float xSize = 100;
    public float ySize = 100;

    public void Generate()
    {
        Texture2D texture = new Texture2D((int)xSize, (int)ySize);
        var colors = new Color[(int)xSize * (int)ySize];
        // for (int x = 0; x < xSize; x++)
        // {
        //     for (int y = 0; y < ySize; y++)
        //     {
        //         colors[y * xSize + x] = Color.black;
        //     }
        // }

        var random = new Unity.Mathematics.Random((uint)Time.time);
        Vector2[] points = new Vector2[nrOfPoints];
        for (int i = 0; i < nrOfPoints; i++)
        {
            var coord = random.NextFloat2(0, (int)xSize);
            points[i] = new Vector2(coord.x, coord.y);
            colors[(int)coord.x * (int)xSize + (int)coord.y] = Color.white;
        }


        if (!drawpointsOnly)
        {
            float cellIndex = 0;
            Vector2 distance =  new Vector2(0,0);
            for (float x = 0; x < xSize; x++)
            {
                for (float y = 0; y < ySize; y++)
                {
                    float minDistance = xSize;

                    for (int i = 0; i < nrOfPoints; i++)
                    {
                        distance.x = (x - points[i].x) / xSize;
                        distance.y = (y - points[i].y) / ySize;
                        if (distance.magnitude < minDistance)
                        {
                            minDistance = distance.magnitude ;
                            cellIndex = i;
                        }
                    }

                    if (drawColorRegions)
                    {
                        colors[(int)x * (int)xSize + (int)y] = new Color(cellIndex/(float)points.Length, cellIndex/(float)points.Length, cellIndex/(float)points.Length, 1);
                    }
                    else
                    {
                        colors[(int)x * (int)xSize + (int)y] = new Color(minDistance, minDistance, minDistance, 1);
                    }
                }
            }
        }
        

        material.mainTexture = texture;
        texture.SetPixels(colors);
        texture.Apply();
    }
    
}



