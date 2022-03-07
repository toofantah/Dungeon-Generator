using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public GameObject cube;
    public int width = 30;
    public int depth = 30;

    // Start is called before the first frame update
    void Start()
    {
        for (int X = 0; X < depth; X++)
        {
            for (int Z = 0; Z < width; Z++)
            {
                Vector3 pos = new Vector3(X, 0, Z);
                Instantiate(cube, pos, Quaternion.identity);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
