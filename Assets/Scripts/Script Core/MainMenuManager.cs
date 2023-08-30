using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject aboutUs;
    


    public void PlayGame()
    {
        SceneManager.LoadScene("Loading");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void AboutUs()
    {
        aboutUs.SetActive(true);
    }

    public void CloseAbout()
    {
        aboutUs.SetActive(false);
    }


}
