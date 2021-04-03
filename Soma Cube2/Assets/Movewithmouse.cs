using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movewithmouse : MonoBehaviour
{
    // Rigidbody rb;
    
    void Start()
    {
        Debug.Log("Movewithmouse is working");

    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z); //Gives values for xyz, the last part is the negative position of the camera plus the objects position. This stops the object from teleporting like in drag 1.0 


        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); //New vector called objPosition. See script called screen to world point, for a clearer explanation. 

        transform.position = objPosition;

        //rb.isKinematic = true;
        

    }

    private void OnMouseUp()
    {
      //  rb.isKinematic = false; // What this part does is that it stops the object from being acted upon by another force
    }


}