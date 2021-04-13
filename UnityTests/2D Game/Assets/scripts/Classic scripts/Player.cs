using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject projectile;
    public GameObject projectileClone;
    void Start()
    {
        
    }

     void Update()
    {
        if(GameManager.lives > 0)
        {
            movement();
            fireProjectile();
        }
    }


    void movement()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }

    }
    
    void fireProjectile()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f, 0), player.transform.rotation) as GameObject;
        }
        if (Input.GetMouseButtonDown(0))
        {
            projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f, 0), player.transform.rotation) as GameObject;
        }
    }
}
