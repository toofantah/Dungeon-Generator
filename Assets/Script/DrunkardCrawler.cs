using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrunkardCrawler : Maze
{
    public override void Generate()
    {
        for (int i = 0; i < 5; i++)
        {
            CrawlVertically();
        }
        for (int i = 0; i < 6; i++)
        {
            CrawlHorizontaly();
        }
        
    }

    void CrawlVertically()
    {
        bool isDone = false;
        int x = UnityEngine.Random.Range(1, width-1);
        int z = 1;

        while (!isDone)
        {
            map[x, z] = 0;
            ///making sure that our crawler only goes vertical or Horizontal but Not both at the same time
            if (UnityEngine.Random.Range(0, 100) < 50)
                x += UnityEngine.Random.Range(-1, 2);
            else
                z += UnityEngine.Random.Range(-0, 2);


            isDone |= (x < 1 || x >= width - 1 || z < 1 || z >= depth - 1);

        }
    }

    void CrawlHorizontaly()
    {
        bool isDone = false;
        int x = 1;
        int z = UnityEngine.Random.Range(1,depth-1);

        while (!isDone)
        {
            map[x, z] = 0;
            ///making sure that our crawler only goes vertical or Horizontal but Not both at the same time
            if (UnityEngine.Random.Range(0, 100) < 50)
                x += UnityEngine.Random.Range(0, 2);
            else
                z += UnityEngine.Random.Range(-1, 2);


            isDone |= (x < 1 || x >= width - 1 || z < 1 || z >= depth - 1);
        }
    }
}
