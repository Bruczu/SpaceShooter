using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour
{
    public PlayerController playerController;
    public int pointsToGet;

    void Update()
    {
        if (playerController.points >= pointsToGet)
        {
            Debug.Log("Zebra�e� wymagan� ilo�� punkt�w! Brawo, wygra�e�! Koniec gry.");
            GoWinMenu();
        }
    }
    public static void GoWinMenu()
    {
        SceneManager.LoadScene("WonMenu", LoadSceneMode.Single);
    }
}
