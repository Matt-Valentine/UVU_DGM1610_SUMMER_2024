using UnityEngine;
public class PlayerController : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 5f;
	[SerializeField] private float jumpForce = 5f;
	[SerializeField] private float gravity = 9.81f;

	private CharacterController _controller; 
	private Vector3 _moveDirection;
	private bool _isJumping; 

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();

		if (_controller != null)
		{
			Debug.Log("CharacterController component found/assigned.");
		}
		else
		{
			Debug.LogError("CharacterController not found. Please attach");
		}
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
		float moveZ = Input.GetAxis("Vertical");

	// Calculate movement direction based on input
		Vector3 move = transform.right * moveX + transform.forward * moveZ;

		if (_controller.isGrounded)
		{
			_moveDirection = move * moveSpeed;
			
			if (Input.GetButtonDown("Jump"))
			{
				_moveDirection.y = jumpForce;
				_isJumping = true;
			}
			else
			{ 
				_moveDirection.y = 0f;
			}
		}
		else
		{ 
			// Gravity applied
			_moveDirection.y -= gravity * Time.deltaTime;
		}

		// Move the player
		_controller.Move(_moveDirection * Time.deltaTime);

	// reset jump
		if (_isJumping && !Input.GetButton("Jump"))
		{
			_isJumping = false;
		}
    }
			
}