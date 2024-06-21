using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 0.75f;
    public float rotationSpeed = 100.0f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * (rotationSpeed * verticalInput * Time.deltaTime));
    }
}
