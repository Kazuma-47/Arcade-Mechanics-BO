using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Optionmenu;
    public GameObject Mainmenu;
    public void Play()
    {
        SceneManager.LoadScene("game");  
    }
    public void Options()
    {
        Optionmenu.SetActive(true);
        //GameObject.Find("OptionsMenu").active = true;
        Mainmenu.SetActive(false);
        
    }
    public void Back()
    {
        Mainmenu.SetActive(true);
        Optionmenu.SetActive(false);
        
    }
}
