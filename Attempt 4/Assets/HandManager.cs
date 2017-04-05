using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour {

    [SerializeField]
    private BoxCollider handTriggered;
    [SerializeField]
    private GenerateWorld worldManager;
    [SerializeField]
    private GameObject GameController;
	
    // Use this for initialization
	void Update () {
        GameController = GameObject.FindGameObjectWithTag("GameController");
        worldManager = GameController.GetComponent<GenerateWorld>();
        handTriggered = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider something) {
        print("Hand hit something.");
            if (something.gameObject.tag == "Block") {
            worldManager.DestroyBlock(something.transform.gameObject);
        }
		
	}
}
