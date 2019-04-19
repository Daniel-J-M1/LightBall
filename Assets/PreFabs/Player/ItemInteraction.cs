using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {

    public GameObject LightBall;
    private GameObject SpawnBall;
    public Transform Player;
    public bool Spawned = false;
    private bool Coll = false;
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
        SPoint.y = Player.position.y;
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
                print("Spawned");
            }
            //======================


        }
        //============================================

        if (Input.GetButtonDown("Despawn"))
        {
            if (Coll == true)
            {
                Destroy(SpawnBall);
                Spawned = false;
                print("Despawned" + Spawned);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "LightBall")
        {
            SpawnBall = other.transform.gameObject;
            Coll = true;
            print("Coll: " + Coll);
            print("Collided");

            //Destroy(other.transform.gameObject);
            //Spawned = false;
            //print("Collided");


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "LightBall")
        {
            Coll = false;
            print("Coll: " + Coll);
        }
    }
}
