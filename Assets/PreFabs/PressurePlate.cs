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
        if (other.transform.tag == "MainCamera")
        {
            print("In");
            Pressure = true;
            print("Pressure: " + Pressure);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "MainCamera")
        {
            print("Out");
            Pressure = false;
            print("Pressure: " + Pressure);
        }
    }
}
