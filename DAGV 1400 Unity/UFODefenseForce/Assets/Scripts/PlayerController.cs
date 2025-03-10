using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 20;
    public Transform blaster;

    public GameObject blasterBolt;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //                              GameObject    Script Component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference GameManager script on Object
    }

    // Update is called once per frame
    void Update()
    {
        // Set horizontal key binding
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves player left/right
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        
        // Player Boundary Left Side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        // Player Boundary Right Side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        // If space is pressed fire blaster
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // Second condition prevents player from shooting after Gamer Over
        {
            // Create blasterBolt at blaster location
            Instantiate(blasterBolt, blaster.transform.position, blasterBolt.transform.rotation);
        }
    }

    // Delete objects that collide with player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
