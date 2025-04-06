using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerController : MonoBehaviour
{
    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPosition.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
