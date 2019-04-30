using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour {

    public GameObject LightBall;
    private GameObject SpawnBall;
    public Transform Player;

    public bool Spawned = false;
    public bool Coll = false;

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
                //Spawns a Lightball and sets it to be referenced by the GameObject "SpawnBall".
                SpawnBall = Instantiate(LightBall, SPoint, Player.rotation);
                //=============================
                Spawned = true;
            }
            //======================
        }
        //============================================

        //Checks to see if the "Despawn" button is pressed
        if (Input.GetButtonDown("Despawn"))
        {
            if (Coll == true)
            {
                //If the boolean is true, destroy the spawned Lightball
                Destroy(SpawnBall);
                //=============================
                Spawned = false;
            }
        }
        //=============================
    }

    //Checks to see if an object has entered the collision box on the player
    void OnTriggerEnter(Collider other)
    {
        //Check to see if the object has the tag "LightBall".
        if (other.transform.tag == "LightBall")
        {
            Coll = true;
        }
        //=============================

        //Check to see if the object has the tag "Respawn".
        if (other.transform.tag == "Respawn")
        {
            Coll = true;
        }
        //=============================
    }

    //Checks to see if an object has entered the collision box on the player
    private void OnTriggerExit(Collider other)
    {
        //Check to see if the object has the tag "LightBall".
        if (other.transform.tag == "LightBall")
        {
            Coll = false;
        }
        //=============================

        //Check to see if the object has the tag "Respawn".
        if (other.transform.tag == "Respawn")
        {
            Coll = false;
        }
        //=============================
    }
    //=============================
}
