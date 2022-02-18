using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 0f;

    private Vector3 mouseOrigin;
    private bool isPanning;
    
    public Vector2 MouseInput()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        return new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 0: left and 1: right
        {
            mouseOrigin = Input.mousePosition;
            isPanning = true;
        }

        // cancel on button release
        if (!Input.GetMouseButton(1))
        {
            isPanning = false;
        }

        //move camera on X & Y
        if (isPanning)
        {
            Vector2 input = MouseInput();
            Debug.Log(Time.deltaTime);
            transform.Rotate(input.y * panSpeed * Time.deltaTime, input.x * panSpeed * Time.deltaTime, 0);
            /* if (input.y > 0)
            {
                transform.Rotate(Vector3.up * input.y * panSpeed * Time.deltaTime);
            } */
        }

    }
}
