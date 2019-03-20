using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {

    public GameObject LightBall;
    public Transform Player;
    public bool Spawned = false;
    private float Move = 2f;
    private Vector3 SPoint;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void FixedUpdate () {

        //Detailing the position the ball will spawn in.
        SPoint.y = Player.position.y + 3;
        SPoint.z = Player.position.z;
        SPoint.x = Player.position.x;
        //============================================

        //Spawn the ball when "E" is pressed.
        if (Input.GetButtonDown("BallSpawn"))
        {
            //Checks to see if the ball is already spawned.
            if (Spawned == false)
            {
                Instantiate(LightBall, SPoint, Player.rotation);
                Spawned = true;
            }
            //======================
        }
        //============================================
	}

    void OnTriggerEnter(Collider other)
    {
            if (other.transform.tag == "Finish")
            {
                Destroy(other.transform.gameObject);
                Spawned = false;
                print("Collided");
            }
    }
}
