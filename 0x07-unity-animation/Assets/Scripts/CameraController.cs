using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform pivot;
    protected Vector3 _LocalRotation;
    public float MouseSensitivity = 4f;
    public bool CameraDisabled = false;
    public bool isInverted = false;
    protected float _CameraDistance = 10f;
    public float ScrollSensitvity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;
    
    void Start()
    {
        Cursor.visible = false; // set Cursor invisible
        transform.SetParent(pivot, true);
        isInverted = PlayerPrefs.GetInt("invertYAxis") == 1 ? true : false;
    }

    void LateUpdate()
    {
        if(!CameraDisabled)
        {
            //Rotation of the Camera based on Mouse Coordinates
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                if (!isInverted)
                    _LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;
                else
                    _LocalRotation.y += Input.GetAxis("Mouse Y") * MouseSensitivity;

                //Clamp the y Rotation to horizon and not flipping over at the top
                _LocalRotation.y = Mathf.Clamp(_LocalRotation.y, -20f, 90f);
            }
            //Zooming Input from our Mouse Scroll Wheel
            if(Input.GetAxis("Mouse ScrollWheel") != 0f)
            {
                float ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitvity;

                ScrollAmount *= (_CameraDistance * 0.3f);

                _CameraDistance += ScrollAmount * -1f;

                _CameraDistance = Mathf.Clamp(_CameraDistance, 3f, 20f);
            }
        }

        //Actual Camera Rig Transformations
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
        pivot.rotation = Quaternion.Lerp(pivot.rotation, QT, Time.deltaTime * OrbitDampening);

        if(transform.localPosition.z != this._CameraDistance * -1f)
        {
            transform.localPosition = new Vector3(0f, 2f, Mathf.Lerp(transform.localPosition.z, _CameraDistance * -1f, Time.deltaTime * ScrollDampening));
        }

    }
}
