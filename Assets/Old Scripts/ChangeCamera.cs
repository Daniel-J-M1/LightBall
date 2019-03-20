using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {
    private const string AxisName = "Change";
    public GameObject Camera1;
    public GameObject Camera2;
    public Texture texture;
    private bool PlayerChange = false;

    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }


    private void FixedUpdate()
    {
        //IF the "E" key is pressed, the boolean changes state.
        if (Input.GetButtonDown("Change"))
        {
            if (PlayerChange == false)
            {
                PlayerChange = true;
            }
            else
            {
                PlayerChange = false;
            }
        }

        //Depending on the state of the boolean, the corresponding camera will be active.
        if (PlayerChange == false)
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
        if (PlayerChange == true)
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
    }
    void OnGUI()
    {

    }
    // Original Script Found at https://answers.unity.com/questions/911949/ui-buttons-switch-cameras.html
}
