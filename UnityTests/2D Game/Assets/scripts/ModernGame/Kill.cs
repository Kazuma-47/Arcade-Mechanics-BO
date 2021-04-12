using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public GameObject ob;
    

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "bullet")
        {
            Destroy(ob);
        }
    }
}
