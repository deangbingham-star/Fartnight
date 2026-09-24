using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotX += Input.GetAxis("Mouse X") * sensX;
        rotY += Input.GetAxis("Mouse Y") * sensY;
        rotY = Mathf.Clamp(rotY, minY, maxY);

        // are we spectating?
        if (isSpectator)
        {
            // rotate the cam vertically
            transform.rotation = Quaternion.Euler(-rotY, rotX, 0);
            // movement
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            float y = 0;
            if (Input.GetKey(KeyCode.E))
                y = 1;
            else if (Input.GetKey(KeyCode.Q))
                y = -1;
            Vector3 dir = transform.right * x + transform.up * y + transform.forward * z;
            transform.position += dir * spectatorMoveSpeed * Time.deltaTime;
        }
        else
        {
        }
    }


    [Header("Look Sensitivity")]
    public float sensX;
    public float sensY;
    [Header("Clamping")]
    public float minY;
    public float maxY;
    [Header("Spectator")]
    public float spectatorMoveSpeed;
    private float rotX;
    private float rotY;
    private bool isSpectator;
}


