using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{   
    public GameObject prefab;
    public GameObject spawn;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            GameObject bullet = Instantiate(prefab, new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z), Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();    
            rb.velocity = new Vector3(10, 0, 0);
            Destroy(bullet, 3f);

        }
    }
}
