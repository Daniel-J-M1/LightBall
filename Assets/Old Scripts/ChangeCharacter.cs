using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public GameObject Character1;
    public GameObject Character2;
    public Texture texture;
    void Start()
    {
        Character1.SetActive(true);
        Character2.SetActive(false);
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 50, 50), texture))
        {
            Character1.SetActive(true);
            Character2.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 0, 50, 50), texture))
        {
            Character1.SetActive(false);
            Character2.SetActive(true);
        }
    }
}
