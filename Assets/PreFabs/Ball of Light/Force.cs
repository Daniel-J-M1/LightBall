using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public Rigidbody Rigid;
    public float Thrust = 20;
    public float UpForce = 10;

	// Use this for initialization
	void Start ()
    {
        //This is meant to push the ball in the diedction that the player is facing
        Rigid = GetComponent<Rigidbody>();
        Rigid.velocity = new Vector3(this.transform.forward.x* Thrust, this.transform.forward.y * UpForce, this.transform.forward.z * Thrust);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
