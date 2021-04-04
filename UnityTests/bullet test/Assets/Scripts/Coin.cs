using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public GameObject pl;
    public GameObject ob;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "player")
        {
            Destroy(ob );
        }
    }
}
