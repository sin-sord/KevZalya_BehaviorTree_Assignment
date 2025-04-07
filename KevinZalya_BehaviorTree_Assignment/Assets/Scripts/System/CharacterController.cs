using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Health")]
    public float healthAmount;
    public Transform spawnPosition;
    public GameObject bullet;
    public float amount;

    [Header("Movement")]
    public float movementSpeed;
    float xMovement;
    float zMovement;

    CharacterController ch;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPosition.transform.position;
        ch = GetComponent<CharacterController>();
        healthAmount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        zMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        ch.Move(new Vector3(xMovement, 0, zMovement));
        healthOfPlayer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Bullet"))
        {
        }
    }

    void healthOfPlayer()
    {

        if (healthAmount <= 0)
        {
            transform.position = spawnPosition.transform.position;
            healthAmount = 100;
        }

    }
}



