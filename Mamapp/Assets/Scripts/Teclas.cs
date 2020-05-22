using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclas : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key was released.");
        }
    }
}