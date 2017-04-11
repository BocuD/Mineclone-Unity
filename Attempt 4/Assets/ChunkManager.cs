using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour {

    public GameObject Chunk;
    public int Seed;

	// Use this for initialization
	void Start () {
        Seed = (int)Network.time;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
