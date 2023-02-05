using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSens = 100f;

    public Transform player;

    private float Xrot = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        Xrot -= mouseY;
        Xrot = Mathf.Clamp(Xrot, -90, 90);

        transform.localRotation = Quaternion.Euler(Xrot, 0, 0);
        player.Rotate(Vector3.up * mouseX);
    }
}
