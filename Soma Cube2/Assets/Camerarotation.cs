using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camerarotation : MonoBehaviour

{
    public float strength;
    public float fov;
  
    // Update is called once per frame
    void Update()
    {

         

     
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, -strength * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, strength * Time.deltaTime, 0);
        }

        if (Input.GetKey("down"))
        {
            transform.Rotate(-strength * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Rotate(strength * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("1"))
        {
            transform.Rotate(0, 0, strength * Time.deltaTime);
        }

        if (Input.GetKey("2"))
        {
            transform.Rotate(0, 0, -strength * Time.deltaTime);
        }

    }

}






