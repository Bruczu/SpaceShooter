using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour
{
    public PlayerController playerController;
    public int pointsToGet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.points >= pointsToGet)
        {
            Debug.Log("Zebra³eœ wymagan¹ iloœæ punktów! Brawo, wygra³eœ! Koniec gry.");
            GoWinMenu();
        }
    }
    public static void GoWinMenu()
    {
        SceneManager.LoadScene("WonMenu", LoadSceneMode.Single);
    }
}
