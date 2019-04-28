﻿using System.Collections;
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

    //BoxRespawn Area;

    // Use this for initialization
    void Start () {
        Rigid = LightBall.GetComponent<Rigidbody>();

        //Area = FindObjectOfType<BoxRespawn>();
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
                //Instantiate(LightBall, SPoint, Player.rotation);
                SpawnBall = Instantiate(LightBall, SPoint, Player.rotation);
                Spawned = true;
                //print("Spawned");
            }
            //======================
        }
        //============================================

        //Coll = Area.GetComponent<BoxRespawn>().Spawn;

        if (Input.GetButtonDown("Despawn"))
        {
            if (Coll == true)
            {
                Destroy(SpawnBall);
                Spawned = false;
                //print("Despawned" + Spawned);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "LightBall")
        {
            Coll = true;
        }

        if (other.transform.tag == "Respawn")
        {
            Coll = true;
            print("Entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "LightBall")
        {
            Coll = false;
        }

        if (other.transform.tag == "Respawn")
        {
            Coll = false;
        }
    }
}
