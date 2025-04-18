using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using TMPro;

public class bulletMovement : MonoBehaviour
{
    [Header("Bullet Direction")]
    public float speed;
    public Vector3 player;
    Vector3 direction;

    [Header("Bullet Time")]
    public float time;
    public float bulletTime;

    void Update()
    {
        // startes the timer for how long the bullet will last
        time += Time.deltaTime;

        //setting the direciton of the where the bullet is going
        direction = (player - transform.position);
        transform.position += direction * speed * Time.deltaTime;
        bulletLifeTime();
    }

    void bulletLifeTime()
    {
        //once bullet time is reached then destroy the bullet object
        if (time >= bulletTime)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // if the the bullet collides with an object with the Player tag then decrease that objects health
        if (collision.gameObject.tag == ("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovement>().healthAmount -= 20;
            Destroy(gameObject);
        }

    }
}
