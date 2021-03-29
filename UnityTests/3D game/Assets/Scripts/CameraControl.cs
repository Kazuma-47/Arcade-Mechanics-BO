using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera cm;
    public Transform pl;
    private Vector3 begin_camera_plaats;
    private Vector3 playerPos;
 
    // Update is called once per frame
    void FixedUpdate()
    {
       float playerPos = pl.position.x; //constant de speler positie checken
        //Debug.Log(playerPos);            //laat player positie zien



        if(playerPos < -25)
        {   
           cm.transform.position = new Vector3(-21.87f, 6.01f, -8.86f);
           cm.transform.rotation = Quaternion.Euler(8.328f, -88.298f, -0.113f);
        }

        if (Input.GetKey("q"))
        {
            cm.transform.position = new Vector3(-10, 6, 12);
        }
    }
}
