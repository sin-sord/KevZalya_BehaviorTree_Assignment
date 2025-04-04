using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public float speed;
    public Vector3 player;
    public float time;
    public float bulletTime;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        Vector3.MoveTowards(transform.position - player, player, 50);
        transform.position += transform.position * speed * Time.deltaTime;
        bulletLifeTime();
    }

    void bulletLifeTime()
    {
        if(time >= bulletTime)
        {
            Destroy(gameObject);
        }
        
    }
}
