using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrunkardCrawler : Maze
{
    public override void Generate()
    {
        bool isDone = false;
        int x = width / 2;
        int z = depth / 2;

        while (!isDone)
        {
            map[x, z] = 0;
            ///making sure that our crawler only goes vertical or Horizontal but Not both at the same time
            if (UnityEngine.Random.Range(0,100)<50) 
                x += UnityEngine.Random.Range(-1, 2);
           else
                z += UnityEngine.Random.Range(-1, 2);


            isDone |= (x < 0 || x >= width || z < 0 || z >= depth);
        }
    
    }
}
