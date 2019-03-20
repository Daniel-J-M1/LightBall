using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour {

    public GameObject Mouse;

    public Vector3 OffSet;

	// Use this for initialization
	void Start () {
        // This sets the original position of the character in relevance to its currrent posiiton from the character
        // This position is stored using the "OffSet" Variable
        OffSet = transform.position - Mouse.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        // This moves the camera in conjunction with the player as they move within the scene, allowing for the player to remain in the smae position of the camera throughout the game.
        transform.position = Mouse.transform.position + OffSet;
	}
}
