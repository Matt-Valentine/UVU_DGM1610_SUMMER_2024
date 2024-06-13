using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Scripts as Behavior Components
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.Green;
        }
        if (Input>GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.Blue;
        }
    }

}
