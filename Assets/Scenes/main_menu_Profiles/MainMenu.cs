using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void Settings()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
