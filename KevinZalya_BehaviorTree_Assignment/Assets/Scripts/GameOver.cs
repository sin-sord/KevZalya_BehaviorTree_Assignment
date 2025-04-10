using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject player;

    private void Start()
    {
        gameOverText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over!");
        gameOverText.SetActive(true);

    }

}
