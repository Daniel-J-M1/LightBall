using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public Rigidbody Cube;
    public float Thrust = 2f;

	// Use this for initialization
	void Start () {
        Cube = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "MainCamera")
        //if (Input.GetButtonDown("Push"))
        {
            print("Collide");

            //======
            //var magnitude = 5;

            //var force = transform.position - other.transform.position;

            //force.Normalize();
            //gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
            ////======



            //Cube.AddForce(transform.forward * Thrust);
            Cube.velocity = new Vector3(this.transform.forward.x * Thrust, this.transform.forward.y, this.transform.forward.z * Thrust);
            //.GetAxis("Horizontal") * Speed;
            print("Force: " + Cube);
        }

    }
}
