using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour
{
    public float fov;
    void Update()
    {
        if (Input.GetKey("="))
            Camera.main.fieldOfView = Camera.main.fieldOfView - fov * Time.deltaTime;
        if (Input.GetKey(KeyCode.KeypadPlus))
            Camera.main.fieldOfView = Camera.main.fieldOfView - fov * Time.deltaTime;


        if (Input.GetKey(KeyCode.KeypadMinus))
            Camera.main.fieldOfView = Camera.main.fieldOfView + fov * Time.deltaTime;
        if (Input.GetKey("-"))
            Camera.main.fieldOfView = Camera.main.fieldOfView + fov * Time.deltaTime;
    }
}
