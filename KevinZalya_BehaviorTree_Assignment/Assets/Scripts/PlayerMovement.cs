using UnityEngine;
using UnityEngine.SceneManagement;

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

        playerHasDied();
    }

    void playerHasDied()
    {
        //  if the healh of the player reaches 0 reset their position to spawn
        if (healthAmount <= 0)
        {
            Debug.Log("player died!");

            // when the player dies then it goes to the "Game Over" scene
            transform.position = spawnPosition.transform.position;
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(nextSceneIndex);  // loads the next scene
        }
    }
}
