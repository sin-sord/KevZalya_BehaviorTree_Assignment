using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class bulletMovement : MonoBehaviour
{
    public float speed;
    public Vector3 player;
    Vector3 direction;
    public float time;
    public float bulletTime;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //setting the direciton of the where the bullet is going
        direction = (player - transform.position);
        transform.position += direction * speed * Time.deltaTime;
        bulletLifeTime();
    }

    void bulletLifeTime()
    {
        //once bullet time is reached then destroy the bullet object
        if(time >= bulletTime)
        {
            Destroy(gameObject);
        }
        
    }
}
