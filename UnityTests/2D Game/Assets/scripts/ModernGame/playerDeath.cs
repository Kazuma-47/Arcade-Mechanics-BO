using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerDeath : MonoBehaviour
{
    public GameObject ob;


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "enemy bullet")
        {
          
            SceneManager.LoadScene("Game Over");
        }
        if (collisionInfo.collider.tag == "enemy")
        {
                
            SceneManager.LoadScene("Game Over");
        }
    }
}
