using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block1
{
    public int type;
    public bool vis;
    public Block1(int t, bool v)
    {
        type = t;
        vis = v;
    }
}

public class Chunk : MonoBehaviour {

    private ChunkManager manager;

    public static int width = 16;
    public static int depth = 16;
    public static int height = 256;

    public int heightScale = 20;
    public int heightOffset = 100;
    public float detailScale = 25.0f;

    Block1[,,] worldBlocks = new Block1[width, height, depth];

    public GameObject block;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ChunkManager>();
        int seed = manager.Seed;
        for (int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++)
            {
                int y = (int)(Mathf.PerlinNoise((x + seed) / detailScale, (z + seed) / detailScale) * heightScale) + heightOffset;
                Vector3 blockPos = new Vector3(x, y, z);

                CreateBlock(y, blockPos, true);
                while (y > 0)
                {
                    y--;
                    blockPos = new Vector3(x, y, z);
                    CreateBlock(y, blockPos, false);
                }
            }
        }
    }
    void CreateBlock(int y, Vector3 blockPos, bool create)
    {
        if (create)
        {
            Instantiate(block, blockPos, Quaternion.identity);
            worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z] = new Block1(1, create);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
