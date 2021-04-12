using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterAim : MonoBehaviour
{
    public GameObject pl;
    public Transform pos;
    
    private void RotateTowards(Vector2 pl)
    {
        var offset = 90f;
        Vector2 direction = pl - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    }
    private void FixedUpdate()
    {
        RotateTowards(pos.position);
    }
}
