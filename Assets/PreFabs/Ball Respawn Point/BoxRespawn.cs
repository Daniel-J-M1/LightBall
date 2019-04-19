using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRespawn : MonoBehaviour {

    public bool Spawn;
    public GameObject Character;

    ItemInteraction Ball;

	// Use this for initialization
	void Start () {

        Ball = FindObjectOfType<ItemInteraction>();

    }
	
	// Update is called once per frame
	void Update () {
        Spawn = Ball.GetComponent<ItemInteraction>().Spawned;
        print("Ball" + Spawn);

        if (Input.GetButtonDown("Despawn"))
        {
            Spawn = false;
        }
    }
}
