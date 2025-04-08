using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Health")]
    public int healthAmount;
    float amount;
    public Transform spawnPosition;

    [Header("Movement")]
    public float movementSpeed;
    float xMovement;
    float zMovement;
    CharacterController ch;
    public float dashSpeed;



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
        //  moves the player
        xMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        zMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        ch.Move(new Vector3(xMovement, 0, zMovement));
        healthOfPlayer();
        dashing();
    }

    void healthOfPlayer()
    {
        //  if the healh of the player reaches 0 reset their position to spawn
        if (healthAmount <= 0)
        {
            transform.position = spawnPosition.transform.position;
            healthAmount = 100;
        }

    }

    void dashing()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            xMovement = Input.GetAxis("Horizontal") * movementSpeed * dashSpeed * Time.deltaTime;
            zMovement = Input.GetAxis("Vertical") * movementSpeed * dashSpeed * Time.deltaTime;
        }
    }
}



