using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {

    public GameObject LightBall;
    public Transform Player;
    public bool Spawned = false;
    private Vector3 SPoint;
    public Rigidbody Rigid;

    // Use this for initialization
    void Start () {
        Rigid = LightBall.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {

        Vector3 Velocity = Rigid.velocity;

        //Detailing the position the ball will spawn in.
        SPoint.y = Player.position.y + 1;
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
