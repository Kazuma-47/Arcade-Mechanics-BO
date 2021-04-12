using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suicideenemy : MonoBehaviour
{
    public GameObject pl;
    public Transform pos;
    public float speed;
    // Update is called once per frame
    private void RotateTowards(Vector2 pl)
    {
        var offset = 90f;
        Vector2 direction = pl - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    }

    private void MoveTowards(Vector3 pl)
    {
        transform.position = Vector3.MoveTowards(transform.position, pl, speed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        MoveTowards(pos.position);
        RotateTowards(pos.position);
    }
}
