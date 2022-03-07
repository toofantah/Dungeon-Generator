using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLocation
{
    //Vector2Int we don't use it because it use X and Y and we are using X and Z!
    public int x;
    public int z;

    public MapLocation(int _X, int _Z)
    {
        x = _X;
        z = _Z;
    }
}
public class Maze : MonoBehaviour
{
    public GameObject cube;
    public int width = 30;
    public int depth = 30;
    public int scale = 6;

    public byte[,] map;

    // Start is called before the first frame update
    void Start()
    {
        InitialzeMap();
        Generate();
        DrawMap();
    }

   

    private void InitialzeMap()
    {
        map = new byte[width, depth];
        for (int X = 0; X < depth; X++)
        {
            for (int Z = 0; Z < width; Z++)
            {
                map[X, Z] = 1; // 1 = wall 0 = corridor;

            }
        }
    }

    public virtual void Generate()
    {
        for (int X = 0; X < depth; X++)
        {
            for (int Z = 0; Z < width; Z++)
            {
                if(UnityEngine.Random.Range(0,100)<50)
                    map[X, Z] = 0; // 1 = wall 0 = corridor;

            }
        }
    }
    private void DrawMap()
    {
        for (int X = 0; X < depth; X++)
        {
            for (int Z = 0; Z < width; Z++)
            {
                if (map[X, Z] == 1) 
                {
                    Vector3 pos = new Vector3(X * scale, 0, Z * scale);
                    GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    wall.transform.localScale = new Vector3(scale, scale, scale);
                    wall.transform.position = pos;
                }

            }
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
