using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleMouseHole : MonoBehaviour {

    // Where the GameObject will teleport to
    public Transform Destination;
    // All tags that can teleport
    private string TagList = "|Player|Mouse|";

    //private bool Teleport = false;

    public Vector2 Location;

    // Use this for initialization
    void Start () {
        // As Needed
        //print(Destination);
	}
	
	// Update is called once per frame
	void Update () {
        // As Needed
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            if (TagList.Contains(string.Format("|{0}|", other.tag)))
            {
                Location = Destination.transform.position;
                print("Location: " + Location);
                //Teleport = true;
            }

    }
    // Originally found here: https://answers.unity.com/questions/1191795/teleport-script-2.html
}
