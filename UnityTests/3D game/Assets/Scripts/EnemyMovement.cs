using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movement = 1.5f;  //hoever naar links of rechts
    public float speed = 2.0f;     // Hoeveel force naar links en rechts
    private Vector3 beginPos;

    void Start()
    {
        beginPos = transform.position;
        //Debug.Log(beginPos);
    }

    void Update()
    {
        Vector3 v = beginPos;
        v.z += movement * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
