using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wincheck : MonoBehaviour
{
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        //Debug.Log("Enemies left: " + enemies.Length);
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("WIN");
            //endScreen.text = "YOU WON!";
        }
    }
}
