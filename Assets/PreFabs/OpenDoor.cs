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
        DoorOpen.x = Position.position.x + 2f;
        DoorOpen.y = Position.position.y;
        DoorOpen.z = Position.position.z;
        DoorClose.x = Position.position.x;
        DoorClose.y = Position.position.y;
        DoorClose.z = Position.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        Open = PressurePlate.GetComponent<PressurePlate>().Pressure;

        if (Open == true)
        {
            Position.position = DoorOpen;
            print(Open);
        }
        else
        {
            Position.position = DoorClose;
            print("Closed");
        }

    }
}
