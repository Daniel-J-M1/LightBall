using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public GameObject Player;
    public GameObject Ball;
    public Rigidbody Rigid;

	// Use this for initialization
	void Start () {
        Rigid = GetComponent<Rigidbody>();

        Rigid.velocity = new Vector3(this.transform.forward.x* 10, this.transform.forward.y, this.transform.forward.z * 10);


        print("Spawned");

    }
	
	// Update is called once per frame
	void Update () {

    }
}
