using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    private Rigidbody playerRb;

    private PlayerController playerControllerScript;

    private float leftBound = -15.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!playerControllerScript.gameOver)
        {
            Vector3 newPos = playerRb.position + Vector3.left * (Time.deltaTime * speed);
            playerRb.MovePosition(newPos);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
