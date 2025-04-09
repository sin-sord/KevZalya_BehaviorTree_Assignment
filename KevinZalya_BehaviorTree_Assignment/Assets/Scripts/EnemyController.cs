using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [Header("Detection")]
    public GameObject enemy1;
    public Transform player;
    public bool playerDetected;

    [Header("Enemy Color")]
    public GameObject enemy2;
    public MeshRenderer enemy2Mesh;
    public Color alertColor;


    // Start is called before the first frame update
    void Start()
    {
        playerDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        detectedPlayer();
    }

    void detectedPlayer()
    {
        //  if enemy1 and the player are within the set distance...
        if (Vector3.Distance(enemy1.transform.position, player.transform.position) < 10)
        {
            // change the color to red
            Debug.Log("Detected player");
            playerDetected = true;
            alertColor = Color.red;
            enemy2Mesh.material.color = alertColor;
        }
    }
}
