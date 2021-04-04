using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public GameObject ob;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "bullet")
        {
            ob.SetActive(false);
        }
    }
}
