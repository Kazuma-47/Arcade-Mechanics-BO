using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    public GameObject ob;


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "enemy bullet")
        {
            Destroy(ob);
        }
        if (collisionInfo.collider.tag == "enemy")
        {
            Destroy(ob);
        }
    }
}
