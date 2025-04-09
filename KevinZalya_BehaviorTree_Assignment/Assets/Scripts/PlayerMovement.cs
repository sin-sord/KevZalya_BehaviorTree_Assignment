using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Health")]
    public float healthAmount;
    public float maxHealth;
    public Transform spawnPosition;
    bool playerDied;

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
        playerDied = false;
        healthAmount = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //  moves the player
        xMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        zMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        ch.Move(new Vector3(xMovement, 0, zMovement));

        resetPlayerPosition();
    }

    void resetPlayerPosition()
    {
        //  if the healh of the player reaches 0 reset their position to spawn
        if (healthAmount < 0)
        {
            Debug.Log("player died!");
            playerDied = true;
            transform.position = spawnPosition.transform.position;

            if (playerDied == true)
            {
                playerDied = false;
                healthAmount = maxHealth;
            }
        }
    }
}
