using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnp : MonoBehaviour
{
    public GameObject pl;
    public GameObject respawn;

    // Update is called once per frame

    void Start ()
    {
        //pl.transform.position = respawn.transform.position;
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "player")
        {
            pl.transform.position = new Vector3(respawn.transform.position.x , respawn.transform.position.y + 1f, respawn.transform.position.z);
           // Debug.Log(respawn.transform.position);
        }
    }
}
