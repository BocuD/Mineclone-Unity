using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtTexturer : MonoBehaviour {

    public GameObject GrassTexture;
    public GameObject DirtTexture;
    public GenerateWorld blockDatabase;
    public Vector3 myPos;
    public Vector3 objAbove;
    public int i = 10;

	// Update is called once per frame
	void Update () {
        blockDatabase = GameObject.FindGameObjectWithTag("GameController").GetComponent<GenerateWorld>();
        if (i > 0)
        {
            i--;
            myPos = gameObject.transform.position;
            if (blockDatabase.Doesexist((int)transform.position.x, ((int)transform.position.y + 1), (int)transform.position.z) == true)
            {
                TurnIntoDirt();
            }
            else
            {
                TurnIntoGrass();
            }
        }
        else {
            this.enabled = false;
        }
	}
    void TurnIntoGrass()
    {
        GrassTexture.SetActive(true);
    }
    void TurnIntoDirt()
    {
        DirtTexture.SetActive(true);
    }
}
