using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public GameObject Player;
    public GameObject Ball;
    public Rigidbody Rigid;
    public float Thrust = 10;

	// Use this for initialization
	void Start () {
        Rigid = GetComponent<Rigidbody>();

        Rigid.velocity = new Vector3(this.transform.forward.x* Thrust, this.transform.forward.y * Thrust, this.transform.forward.z * Thrust);


        print("Spawned");

    }
	
	// Update is called once per frame
	void Update () {

    }
}
