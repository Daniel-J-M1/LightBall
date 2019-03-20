using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject Player;

    public Vector3 Offset;

	// Use this for initialization
	void Start () {

        Offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

        transform.position = Player.transform.position + Offset;
	}
}
