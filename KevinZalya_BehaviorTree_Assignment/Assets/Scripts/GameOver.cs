using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public GameObject player;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over!");
        if (other.gameObject.CompareTag("Player"))
        {
            textMesh.text = "You've reached the exit!";
            textMesh.color = Color.green;
        }
    }

}
