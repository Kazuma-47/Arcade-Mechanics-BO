using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public int movement;
    public int gravity;

    // Update is called once per frame
    void FixedUpdate()
    {

        //voor
        if (Input.GetKey("w"))
        {
            //Debug.Log("W is gedrukt");
            //werkt niet
            //de vector werkt zo : voor/achter , boven, links/rechts
            //transfrom.position += Vector3(-2, 0, 0) * Time.deltaTime;

            //vervangen want force is niet handig voor movement sinds het over time is
            //rb.AddForce(new Vector3(-50, 0, 0));
            rb.velocity = new Vector3(-movement, gravity, 0);
        }

        //Get.keyup
        //rechts
        if (Input.GetKey("d"))
        {
            //Debug.Log("D is gedrukt");
            //werkt niet
            //transfrom.position += Vector3(-2, 0, 0) * Time.deltaTime;

            //vervangen want force is niet handig voor movement sinds het over time is
            //rb.AddForce(new Vector3(0, 0, 50));
            rb.velocity = new Vector3(0, gravity, movement);
        }
        //achter
        if (Input.GetKey("s"))
        {
            //Debug.Log("S is gedrukt");
            //werkt niet
            //transfrom.position += Vector3(-2, 0, 0) * Time.deltaTime;

            //vervangen want force is niet handig voor movement sinds het over time is
            //rb.AddForce(new Vector3(50, 0, 0));
            rb.velocity = new Vector3(movement, gravity, 0);
        }
        //links
        if (Input.GetKey("a"))
        {
            //Debug.Log("A is gedrukt");
            //werkt niet
            //transfrom.position += Vector3(-2, 0, 0) * Time.deltaTime;

            //vervangen want force is niet handig voor movement sinds het over time is
            //rb.AddForce(new Vector3(0, 0, -50));
            rb.velocity = new Vector3(0, gravity, -movement);
        }
    }
}
//if else maken als je player onder de wereld valt teleport naar respawn
