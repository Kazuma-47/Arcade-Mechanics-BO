using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpPower = 8;
    public bool canJump = true;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.W) && canJump == true)
        {
            rb.velocity = new Vector3(0, jumpPower, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }

}
