using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (playerController.points == pointsToGet)
        {
            Debug.Log("Zebra�e� wymagan� ilo�� punkt�w! Brawo, wygra�e�! Koniec gry.");
            //wygrana = true;
        }
    }
}
