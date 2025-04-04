using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        Vector3.MoveTowards(transform.position, player.transform.position, 50);
        transform.position += speed * Time.deltaTime * Vector3.forward;
    }
}
