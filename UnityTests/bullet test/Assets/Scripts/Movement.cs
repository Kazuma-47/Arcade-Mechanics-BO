using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    void FixedUpdate()
    {
        //voor
       
        //rechts
       
        if (Input.GetKey("d"))
        {

            rb.velocity = (new Vector3(speed, -3, 0));
        }
        //achter
  
        //links
        if (Input.GetKey("a"))
        {

            rb.velocity = (new Vector3(-speed, -3, 0) );
        }
       

   
    }
}
