using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform enemy1;
    public Transform enemy2;

    public Transform player;

    public MeshRenderer enemy1Mesh;
    public MeshRenderer enemy2Mesh;
    public Color changeColorTo;

    public bool playerDetected;

    // Start is called before the first frame update
    void Start()
    {
        changeColorTo = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        detectedPlayer();
    }

    void detectedPlayer()
    {
        if(Vector3.Distance(enemy1.transform.position, player.transform.position) < 5)
        {
            playerDetected = true;
            changeColorTo = Color.red;
        }
        changeColorTo = Color.red;

    }
}
