using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Optionmenu;
    public GameObject Mainmenu;
    public GameObject GameChoice;
    public GameObject Controles;
    public void Play()
    {
        GameChoice.SetActive(true);
        //SceneManager.LoadScene("game");
        Mainmenu.SetActive(false);
    }
    public void ChoiceClassic()
    {
        SceneManager.LoadScene("Classic");
    }
    public void ChoiceModern()
    {
        SceneManager.LoadScene("Modern");
    }
    public void Options()
    {
        Optionmenu.SetActive(true);
        //GameObject.Find("OptionsMenu").active = true;
        Mainmenu.SetActive(false);
        
    }
    public void BackOptions()
    {
        Mainmenu.SetActive(true);
        Optionmenu.SetActive(false);
        
    }
    public void BackControls()
    {
        Mainmenu.SetActive(true);
        Controles.SetActive(false);

    }
    public void BackChoiceMenu()
    {
        Mainmenu.SetActive(true);
        GameChoice.SetActive(false);

    }
    public void Controls()
    {
        Controles.SetActive(true);
        //GameObject.Find("OptionsMenu").active = true;
        Mainmenu.SetActive(false);

    }
}
