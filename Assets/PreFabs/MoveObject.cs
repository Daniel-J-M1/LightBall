using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    private bool Push = false;
    private GameObject Player;
    public Rigidbody Cube;

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
        {
            print("Collide");
            Cube.AddForce(transform.forward * 30);
        }

    }
}
