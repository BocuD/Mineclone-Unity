using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour {

    public GameObject Chunk;
    public int Seed;

    public int Renderdistance = 4;

	// Use this for initialization
	void Start () {
        Seed = (int)Network.time;
        for (int x = -Renderdistance; x < Renderdistance; x++)
        {
            for (int z = -Renderdistance; z < Renderdistance; z++)
            {
                Vector3 chunkPos = new Vector3((x * 16), 0, (z * 16));
                Instantiate(Chunk, chunkPos, Quaternion.identity);
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
