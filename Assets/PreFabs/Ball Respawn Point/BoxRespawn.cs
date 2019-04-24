using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRespawn : MonoBehaviour {

    public bool Spawn;

    ItemInteraction Ball;

	// Use this for initialization
	void Start () {

        Ball = FindObjectOfType<ItemInteraction>();

    }
	
	// Update is called once per frame
	void Update () {
        Spawn = Ball.GetComponent<ItemInteraction>().Coll;
        //print("Ball" + Spawn);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Respawn")
        {
            Spawn = true;
            print("In");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Respawn")
        {
            Spawn = false;
            print("Out");
        }
    }
}
