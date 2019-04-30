using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameObject PressurePlate;
    public bool Open = false;
    public Transform Position;
    public Vector3 DoorOpen;
    public Vector3 DoorClose;

	// Use this for initialization
	void Start () {
        //Sets the position of the door when it is open.
        DoorOpen.x = Position.position.x + 5f;
        DoorOpen.y = Position.position.y;
        DoorOpen.z = Position.position.z;
        //=============================

        //Sets the position of the door when it is closed.
        DoorClose.x = Position.position.x;
        DoorClose.y = Position.position.y;
        DoorClose.z = Position.position.z;
        //=============================
    }
	
	// Update is called once per frame
	void Update () {
        //Gets the boolean variable from the "PressurePlate" script.
        Open = PressurePlate.GetComponent<PressurePlate>().Pressure;

        //Changes the position of the door depending on the boolean "Open".
        if (Open == true)
        {
            Position.position = DoorOpen;
            print(Open);
        }
        else
        {
            Position.position = DoorClose;
        }
        //=============================
    }
}
