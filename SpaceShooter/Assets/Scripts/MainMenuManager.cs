using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public static PlayerController playerController;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Wychodzisz z gry.");
        Application.Quit();
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
