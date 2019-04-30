using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public bool Pressure = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        //Checks to see if an object with the "Crate" tag has entered the collision box.
        if (other.transform.tag == "Crate")
        {
            Pressure = true;
        }
        //=============================
    }

    private void OnTriggerExit(Collider other)
    {
        //Checks to see if an object with the "Crate" tag has exited the collision box.
        if (other.transform.tag == "Crate")
        {
            Pressure = false;
        }
        //=============================
    }
}
