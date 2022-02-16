using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 7.5f;
    public float restartHeight = 0f;
    public Vector3 jump;
    private float jumpHeight = 1.0f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private Vector3 cameraForward = new Vector3(0,0,0);
    private Vector3 cameraRight = new Vector3(0, 0, 0);
    private Vector3 playerGravity;
    private float gravityValue = -12.81f;
    private bool failPlayer = false;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // movement
        cameraForward = Camera.main.transform.forward;
        cameraRight = Camera.main.transform.right;
        cameraForward.y = 0;
        cameraRight.y = 0;

        moveDirection = Vector3.Normalize((Input.GetAxis("Vertical") * cameraForward) +
                                          (Input.GetAxis("Horizontal") * cameraRight));

        // jump
        if(!controller.isGrounded)
        {
            playerGravity.y += gravityValue * Time.deltaTime;
        }
        else if(Input.GetButtonDown("Jump"))
	    {
            playerGravity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
		}
        
        if(!failPlayer)
        {
            controller.Move(moveDirection * Time.deltaTime * playerSpeed);
        }

		controller.Move(playerGravity * Time.deltaTime);

        if (transform.position.y < -20)
        {
            failPlayer  = true;
            transform.position = new Vector3(0.0f, restartHeight, 0.0f);
            playerGravity.y = gravityValue;
        } else if(transform.position.y < 2) {
            failPlayer  = false;
        }
    }

}
