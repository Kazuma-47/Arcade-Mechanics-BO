using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulletdisapear : MonoBehaviour
{
    public GameObject ob;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "player")
        {
            Destroy(ob);
        }
        if (collisionInfo.collider.tag == "level")
        {
            Destroy(ob);
        }
        if (collisionInfo.collider.tag == "bullet")
        {
            Destroy(ob);
        }
    }
}