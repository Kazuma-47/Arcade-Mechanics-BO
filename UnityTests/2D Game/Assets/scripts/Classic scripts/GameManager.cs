using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame = true;

    public Text livesText;
    public Text endScreen;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        livesText.text = "Lives:" + lives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives:" + lives;
        if (lives == 0)
        {
            SceneManager.LoadScene("GameOverClassic");
            //   endScreen.text = "YOU LOSE!";
        }
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //Debug.Log("Enemies left: " + enemies.Length);
        if(enemies.Length == 0)
        {
            SceneManager.LoadScene("WINCLASSIC");
            //endScreen.text = "YOU WON!";
        }

    }
}
