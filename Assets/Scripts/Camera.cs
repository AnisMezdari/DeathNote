using UnityEngine;

public class Camera : MonoBehaviour {

    private GameObject gameObjectPlayer ;
    private float mouseSensitivity;
    private float xAxisClamp;

    private void Start()
    {
        this.gameObjectPlayer = this.transform.parent.gameObject;

        Cursor.lockState = CursorLockMode.Locked;
        this.mouseSensitivity = 150;
        this.xAxisClamp = 0.0f;
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 45.0f)
        {
            xAxisClamp = 45.0f;
            mouseY = 0.0f;
        }
        else if (xAxisClamp < -45.0f)
        {
            xAxisClamp = -45.0f; 
            mouseY = 0.0f;
        }

        this.transform.Rotate(Vector3.left * mouseY);
        this.gameObjectPlayer.transform.Rotate(Vector3.up * mouseX);
    }

    private void Update()
    {
        CameraRotation();
    }
}
