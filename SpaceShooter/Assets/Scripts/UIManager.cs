using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject hp1;
    public GameObject hp2;
    public GameObject hp3;
    public GameObject hp4;
    public GameObject hp5;

    public List<GameObject> hpPointsList = new List<GameObject>();

    public PlayerController playerController;
    public TextMeshProUGUI text;
    public EndGameController endGameController;

    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameManager.uiManager = this;
    }

    void Update()
    {
        text.text = playerController.points.ToString();
    }

    public void DisableHpSprite(int value)
    {
        audioSource.PlayOneShot(audioClip);
        hpPointsList[value-1].SetActive(false);
    }
}
