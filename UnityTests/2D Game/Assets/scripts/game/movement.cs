using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int movemente;



    void Update()
    {

        //voor
        if (Input.GetKey("w"))
        {

            rb.velocity = new Vector3(0, movemente, 0);
        }

        //Get.keyup
        //rechts
        if (Input.GetKey("d"))
        {

            rb.velocity = new Vector3(-movemente, 0, 0);
        }
        //achter
        if (Input.GetKey("s"))
        {

            rb.velocity = new Vector3(0, -movemente, 0);
        }
        //links
        if (Input.GetKey("a"))
        {

            rb.velocity = new Vector3(movemente, 0, 0);
        }



        if (Input.GetKeyUp("w"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp("a"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp("s"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp("d"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}