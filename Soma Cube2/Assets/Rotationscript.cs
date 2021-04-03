using UnityEngine;

public class Rotationscript : MonoBehaviour
{

    public float rotationforce;
    public bool mousebuttonisdown;
    public float moveforce;
    // Start is called before the first frame update
   
    private void OnMouseDown()
    {
        mousebuttonisdown = true; //this is only true if the mouse is being held down.

        Debug.Log("onmousedown is true");
    }


    private void OnMouseUp()
    {
        mousebuttonisdown = false; //this is only false if the released

        Debug.Log("onmousedown is false");
    }


    void OnMouseOver()
    {


        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is on cube");

        if (mousebuttonisdown == true)
        {

            if (Input.GetKey("d"))
                transform.position = transform.position + new Vector3(moveforce * Time.deltaTime, 0f, 0f);
         
            if (Input.GetKey("a"))
                transform.position = transform.position +new Vector3(-moveforce * Time.deltaTime, 0f, 0f);

            if (Input.GetKey("w"))
                transform.position = transform.position + new Vector3(0f, moveforce * Time.deltaTime, 0f);
          
            if (Input.GetKey("s"))
                transform.position = transform.position + new Vector3(0f, -moveforce * Time.deltaTime, 0f);
          
            if (Input.GetKey("q"))
                transform.position = transform.position + new Vector3(0f, 0f, -moveforce * Time.deltaTime);
          
            if (Input.GetKey("e"))
                transform.position = transform.position + new Vector3(0f, 0f, moveforce * Time.deltaTime);


        }




        if (mousebuttonisdown == false) {

            Debug.Log("mouse is not held down");

            if (Input.GetKey("d"))
                transform.Rotate(new Vector3(0f, rotationforce * Time.deltaTime, 0f));


            if (Input.GetKey("a"))
                transform.Rotate(new Vector3(0f, -rotationforce * Time.deltaTime, 0f));

            if (Input.GetKey("w"))
                transform.Rotate(new Vector3(rotationforce * Time.deltaTime, 0f, 0f));


            if (Input.GetKey("s"))
                transform.Rotate(new Vector3(-rotationforce * Time.deltaTime, 0f, 0f));

            if (Input.GetKey("q"))
                transform.Rotate(new Vector3(0f, 0f, rotationforce * Time.deltaTime));


            if (Input.GetKey("e"))
                transform.Rotate(new Vector3(0f, 0f, -rotationforce * Time.deltaTime));

            if (Input.GetKey("z"))
                transform.Rotate(new Vector3(rotationforce * Time.deltaTime, 0f, 0f));

            if (Input.GetKey("x"))
                transform.Rotate(new Vector3(-rotationforce * Time.deltaTime, 0f, 0f));

        }
    }
}
    