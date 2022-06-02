using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Dit script werkt Main Cam van Unity zelf. Voor de player cam is een andere script.
//Gewoon in rond te kijken in een scene bijvoorbeeld.

public class firstperson : MonoBehaviour
{
    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

    }
}
