using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 0f;
    public float restartHeight = 0f;
    public Vector3 jump;
    public float jumpForce = 0.0f;
    private bool isGrounded;
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = new Vector3(0.0f, restartHeight, 0.0f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }

        // jump one time, while isGrounded is true and press Space bar 
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (rb.position.y < -10)
        {
            rb.velocity = Vector3.zero;
            rb.position = startPosition;
        }
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

}
