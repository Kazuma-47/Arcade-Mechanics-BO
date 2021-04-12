using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshoot : MonoBehaviour
{
    public GameObject pl;
    public GameObject prefab;
    public GameObject spawn;
    public int speed = 10;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            GameObject bullet = Instantiate(prefab, new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z), pl.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * -speed;
            Destroy(bullet, 3f);
        }
    }
}
