using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 45.0f;

    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        if (playerRb == null)
        {
            playerRb = gameObject.AddComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.MovePosition(transform.position + transform.forward * (Time.deltaTime * speed));
    }
}
