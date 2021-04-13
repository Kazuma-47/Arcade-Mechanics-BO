using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            ScoreScript.scoreValue += 1;
            Destroy(collision.gameObject);
            Destroy(projectile);
            GameManager.playGame = true;
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(projectile);
        }
    }
}
